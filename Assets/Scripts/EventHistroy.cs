using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class EventHistroy : MonoBehaviour {
    private string path = "Assets/Resources/data.txt";
    private string events;
    private Text text;

    void Start() {
        lookup();
        GetComponent<Text>().text = events;
    }

    // Update is called once per frame
    void Update()
    {
        lookup();
        GetComponent<Text>().text = events;
    }

        void lookup()
        {
            StreamReader reader = new StreamReader(path);
            events = reader.ReadToEnd();
            reader.Close();
        }

    
}

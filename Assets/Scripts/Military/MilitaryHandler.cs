using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MilitaryHandler : MonoBehaviour
{
    private float MilitarySilderGet;
    private Text MilitaryValueGet;
    // Use this for initialization
    void Start()
    {
        MilitarySilderGet = GameObject.Find("Military Slider").GetComponent<Slider>().value;
        MilitaryValueGet = GameObject.Find("Military Value").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        MilitarySilderGet = GameObject.Find("Military Slider").GetComponent<Slider>().value;
        MilitaryValueGet.text = Mathf.Round(MilitarySilderGet).ToString();
    }
}

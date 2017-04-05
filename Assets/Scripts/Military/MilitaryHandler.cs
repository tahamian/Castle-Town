using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MilitaryHandler : MonoBehaviour
{
    private float MilitarySilderGet;
    private Text MilitaryValueGet;
	public GameObject slide;
	public GameObject text;
    // Use this for initialization
    void Start()
    {
        //MilitarySilderGet = GameObject.Find("Military Slider").GetComponent<Slider>().value;
        //MilitaryValueGet = GameObject.Find("Military Value").GetComponent<Text>();
		slide.GetComponent<Slider> ().value = 20;
		text.GetComponent<Text> ().text = Mathf.Round (MilitarySilderGet).ToString ();
    }

    // Update is called once per frame
    void Update()
    {	
		MilitarySilderGet = slide.GetComponent<Slider> ().value;
		text.GetComponent<Text> ().text = Mathf.Round (MilitarySilderGet).ToString ();
    }
}

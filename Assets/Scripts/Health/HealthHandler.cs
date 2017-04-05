using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHandler : MonoBehaviour
{
    private float HealthSilderGet;
    private Text HealthValueGet;
	public GameObject slide;
	public GameObject text;
    // Use this for initialization
    void Start()
    {
        //HealthSilderGet = GameObject.Find("Health Slider").GetComponent<Slider>().value;
        //HealthValueGet = GameObject.Find("Health Value").GetComponent<Text>();
		slide.GetComponent<Slider> ().value = 20;
		text.GetComponent<Text> ().text = Mathf.Round (HealthSilderGet).ToString ();
    }

    // Update is called once per frame
    void Update()
    {
        //HealthSilderGet = GameObject.Find("Health Slider").GetComponent<Slider>().value;
        //HealthValueGet.text = Mathf.Round(HealthSilderGet).ToString();
		HealthSilderGet = slide.GetComponent<Slider> ().value;
		text.GetComponent<Text> ().text = Mathf.Round (HealthSilderGet).ToString ();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EducationHandler : MonoBehaviour
{
    private float EducationSilderGet;
    private Text EducationValueGet;
	public GameObject slide;
	public GameObject text;
    // Use this for initialization
    void Start()
    {
        //EducationSilderGet = GameObject.Find("Education Slider").GetComponent<Slider>().value;
        //EducationValueGet = GameObject.Find("Education Value").GetComponent<Text>();
		slide.GetComponent<Slider> ().value = 20;
		text.GetComponent<Text> ().text = Mathf.Round (EducationSilderGet).ToString ();
    }

    // Update is called once per frame
    void Update()
    {	
		EducationSilderGet = slide.GetComponent<Slider> ().value;
		text.GetComponent<Text> ().text = Mathf.Round (EducationSilderGet).ToString ();
    }
}

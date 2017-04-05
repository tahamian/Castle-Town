using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfrastructureHandler : MonoBehaviour
{
    private float InfrastructureSilderGet;
    private Text InfrastructureValueGet;
	public GameObject slide;
	public GameObject text;
    // Use this for initialization
    void Start()
    {
        //InfrastructureSilderGet = GameObject.Find("Infrastructure Slider").GetComponent<Slider>().value;
        //InfrastructureValueGet = GameObject.Find("Infrastructure Value").GetComponent<Text>();
		slide.GetComponent<Slider> ().value = 20;
		text.GetComponent<Text> ().text = Mathf.Round (InfrastructureSilderGet).ToString ();
    }

    // Update is called once per frame
    void Update()
    {
		InfrastructureSilderGet = slide.GetComponent<Slider> ().value;
		text.GetComponent<Text> ().text = Mathf.Round (InfrastructureSilderGet).ToString ();
    }
}

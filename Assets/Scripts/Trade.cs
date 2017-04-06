using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trade:MonoBehaviour{

	public static float impact;
	public static float traLife;
    public float traSlider;
	public GameObject slider;
	public GameObject text;

    void Start(){
    	traLife = 100;
    	impact = 0;
		slider.GetComponent<Slider>().value = 20;
		text.GetComponent<Text>().text = Mathf.Round(traSlider).ToString();
    }

    void Update(){
    	traLife += impact * (traSlider + 0.3f * Education.eduLife - 0.5f * Military.milLife - 0.2f * Infrastructure.infLife);
    	impact = 0;
    	if(traLife >= 100) traLife = 100;
		traSlider = slider.GetComponent<Slider>().value;
		text.GetComponent<Text>().text = Mathf.Round(traSlider).ToString();
    }
}
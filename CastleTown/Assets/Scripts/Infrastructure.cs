using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Infrastructure:MonoBehaviour{

	public static float impact;
	public static float infLife;
    public float infSlider;
	public GameObject slider;
	public GameObject text;

    void Start(){
    	infLife = 100;
    	impact = 0;
		slider.GetComponent<Slider>().value = 20;
		text.GetComponent<Text>().text = Mathf.Round(infSlider).ToString();
    }

    void Update(){
    	infLife += impact * (infSlider - 0.6f * Military.milLife + 0.1f * Education.eduLife + 0.1f * Trade.traLife);
    	impact = 0;
    	if(infLife >= 100) infLife = 100;
		infSlider = slider.GetComponent<Slider>().value;
		text.GetComponent<Text>().text = Mathf.Round(infSlider).ToString();
    }
}
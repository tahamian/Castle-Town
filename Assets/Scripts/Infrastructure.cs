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
    	impact = 1;
		slider.GetComponent<Slider>().value = 20;
		text.GetComponent<Text>().text = Mathf.Round(infSlider).ToString();
    }

    void Update(){
    	infLife = impact * (infSlider - 0.3f * Military.milLife + 0.3f * Education.eduLife);
		infSlider = slider.GetComponent<Slider>().value;
		text.GetComponent<Text>().text = Mathf.Round(infSlider).ToString();
    }
}
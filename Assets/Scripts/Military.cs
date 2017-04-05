using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Military:MonoBehaviour{

	public static float impact;
	public static float milLife;
    public float milSlider;
	public GameObject slider;
	public GameObject text;

    void Start(){
    	impact = 1;
		slider.GetComponent<Slider>().value = 20;
		text.GetComponent<Text>().text = Mathf.Round(milSlider).ToString();
    }

    void Update(){
    	milLife = impact * (milSlider - 0.3f * Education.eduLife + 0.9f * Trade.traLife + 0.9f * Health.heaLife);
		milSlider = slider.GetComponent<Slider>().value;
		text.GetComponent<Text>().text = Mathf.Round(milSlider).ToString();
    }
}
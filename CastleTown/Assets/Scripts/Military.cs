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
    	milLife = 100;
    	impact = 0;
		slider.GetComponent<Slider>().value = 20;
		text.GetComponent<Text>().text = Mathf.Round(milSlider).ToString();
    }

    void Update(){
    	milLife += impact * (milSlider - 0.6f * Education.eduLife + 0.1f * Trade.traLife + 0.1f * Health.heaLife);
    	impact = 0;
    	if(milLife >= 100) milLife = 100;
		milSlider = slider.GetComponent<Slider>().value;
		text.GetComponent<Text>().text = Mathf.Round(milSlider).ToString();
    }
}
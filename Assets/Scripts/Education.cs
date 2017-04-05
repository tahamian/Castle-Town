using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Education:MonoBehaviour{

	public static float impact;
	public static float eduLife;
    public float eduSlider;
	public GameObject slider;
	public GameObject text;

    void Start(){
    	impact = 1;
		slider.GetComponent<Slider>().value = 20;
		text.GetComponent<Text>().text = Mathf.Round(eduSlider).ToString();
    }

    void Update(){
    	eduLife = impact * (eduSlider - 0.2f * Military.milLife + 1.3f * Trade.traLife);
		eduSlider = slider.GetComponent<Slider>().value;
		text.GetComponent<Text>().text = Mathf.Round(eduSlider).ToString();
    }
}
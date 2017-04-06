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
    	eduLife = 100;
    	impact = 0;
		slider.GetComponent<Slider>().value = 20;
		text.GetComponent<Text>().text = Mathf.Round(eduSlider).ToString();
    }

    void Update(){
    	eduLife += impact * (eduSlider - 0.5f * Military.milLife + 0.1f * Trade.traLife);
    	impact = 0;
    	if(eduLife >= 100) eduLife = 100;
		eduSlider = slider.GetComponent<Slider>().value;
		text.GetComponent<Text>().text = Mathf.Round(eduSlider).ToString();
    }
}
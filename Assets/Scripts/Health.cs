using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health:MonoBehaviour{

	public static float impact;
	public static float heaLife;
    public float heaSlider;
	public GameObject slider;
	public GameObject text;

    void Start(){
    	heaLife = 100;
    	impact = 0;
		slider.GetComponent<Slider>().value = 20;
		text.GetComponent<Text>().text = Mathf.Round(heaSlider).ToString();
    }

    void Update(){
    	heaLife += impact * (heaSlider - 0.6f * Military.milLife - 0.1f * Infrastructure.infLife + 0.1f * Trade.traLife + 0.1f * Education.eduLife);
    	impact = 0;
    	if(heaLife >= 100) heaLife = 100;
		heaSlider = slider.GetComponent<Slider>().value;
		text.GetComponent<Text>().text = Mathf.Round(heaSlider).ToString();
    }
}
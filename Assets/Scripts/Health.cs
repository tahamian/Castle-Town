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
    	impact = 1;
		slider.GetComponent<Slider>().value = 20;
		text.GetComponent<Text>().text = Mathf.Round(heaSlider).ToString();
    }

    void Update(){
    	heaLife = impact * (heaSlider - 0.3f * Infrastructure.infLife + 0.3f * Education.eduLife);
		heaSlider = slider.GetComponent<Slider>().value;
		text.GetComponent<Text>().text = Mathf.Round(heaSlider).ToString();
    }
}
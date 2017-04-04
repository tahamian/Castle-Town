using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour {
	private float TradeSlider;
	// Use this for initialization
	void Start () {
        if (PlayerPrefs.HasKey("TradeSlider"))
        {
            TradeSlider = PlayerPrefs.GetFloat("TradeSlider");
        }
        else {
            PlayerPrefs.SetFloat("TradeSlider", GameObject.Find("Trade Slider").GetComponent<Slider>().value);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void save(){
		PlayerPrefs.SetFloat ("TradeSlider", GameObject.Find ("Trade Slider").GetComponent<Slider> ().value);

	}
	public void load(){
		TradeSlider = PlayerPrefs.GetFloat ("TradeSlider");
	}

}

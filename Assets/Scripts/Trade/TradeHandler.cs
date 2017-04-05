using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradeHandler : MonoBehaviour {
	private float TradeSilderGet;
	private Text TradeValueGet;
	public GameObject slide;
	public GameObject text;
	// Use this for initialization
	void Start () {
		//TradeSilderGet = slide.GetComponent<Slider> ().value;
		//TradeValueGet = text.GetComponent<Text> ();
		slide.GetComponent<Slider> ().value = 20;
		text.GetComponent<Text> ().text = Mathf.Round (TradeSilderGet).ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		TradeSilderGet = slide.GetComponent<Slider> ().value;
		text.GetComponent<Text> ().text = Mathf.Round (TradeSilderGet).ToString ();
	}
}

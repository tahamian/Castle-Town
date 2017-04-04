using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradeHandler : MonoBehaviour {
	private float TradeSilderGet;
	private Text TradeValueGet;
	// Use this for initialization
	void Start () {
		TradeSilderGet = GameObject.Find ("Trade Slider").GetComponent<Slider> ().value;
		TradeValueGet = GameObject.Find ("Trade Value").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		TradeSilderGet = GameObject.Find ("Trade Slider").GetComponent<Slider> ().value;
		TradeValueGet.text = Mathf.Round (TradeSilderGet).ToString ();
	}
}

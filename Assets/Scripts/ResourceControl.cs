using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceControl:MonoBehaviour{

	private float currResource;
	public float resrouceMax;
	private float resourceLeft;
    public Text text;
	public Slider tradeSlider;
	public Slider militarySlider;
	public Slider healthSlider;
	public Slider infrastructureSlider;
	public Slider educationSlider;

	private float currTradeVal;
	private float currHealthVal;
	private float currInfraVal;
	private float currMilitaryVal;
	private float currEduVal;

	void Start(){
		currEduVal = 20f;
		currHealthVal = 20f;
		currInfraVal = 20f;
		currMilitaryVal = 20f;
		currTradeVal = 20f;
		resourceLeft = 0;
        text.GetComponent<Text>().text = Mathf.Round(resourceLeft).ToString();
    }

	void Update(){
		float tradeVal = tradeSlider.value;
		float militaryVal = militarySlider.value;
		float healthVal = healthSlider.value;
		float infrastructureVal = infrastructureSlider.value;
		float educationVal = educationSlider.value;
        text.GetComponent<Text>().text = Mathf.Round(resourceLeft).ToString();
        currResource = tradeVal + militaryVal + healthVal + infrastructureVal + educationVal;
       
        if (currResource > resrouceMax){
			currTradeVal = Mathf.Min (currTradeVal, tradeVal);
			currHealthVal = Mathf.Min (currHealthVal, healthVal);
			currInfraVal = Mathf.Min (currInfraVal, infrastructureVal);
			currMilitaryVal = Mathf.Min (currMilitaryVal, militaryVal);
			currEduVal = Mathf.Min (currEduVal, educationVal);
			currResource = currTradeVal + currHealthVal + currInfraVal + currMilitaryVal + currEduVal;
		}
		
		else{
			currTradeVal = tradeVal;
			currEduVal = educationVal;
			currHealthVal = healthVal;
			currInfraVal = infrastructureVal;
			currMilitaryVal = militaryVal;
		}

		resourceLeft = resrouceMax - currResource;
		tradeSlider.value = currTradeVal;
		militarySlider.value = currMilitaryVal;
		healthSlider.value = currHealthVal;
		educationSlider.value = currEduVal;
		infrastructureSlider.value = currInfraVal;
	}
}	
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger:MonoBehaviour{

	private string negative;
	private string positive;

	void Start(){
		Negative();
		Positive();
	}

	private void Negative(){
		negative = Events.GetNeg();
		Debug.Log(negative);
		Invoke("Negative", Random.Range(5, 10));
	}

	private void Positive(){
		positive = Events.GetPos();
		Debug.Log(positive);
		Invoke("Positive", Random.Range(10, 20));
	}
}
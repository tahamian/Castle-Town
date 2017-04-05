using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger:MonoBehaviour{

	private string[] gameEvent;

	void Start(){
		Negative();
		Positive();
	}

	private void Negative(){
		gameEvent = Events.GetNeg();
		Impact();
		Invoke("Negative", Random.Range(5, 10));
	}

	private void Positive(){
		gameEvent = Events.GetPos();
		Impact();
		Invoke("Positive", Random.Range(10, 20));
	}

	private void Impact(){
		Health.impact = float.Parse(gameEvent[1]);
		Education.impact = float.Parse(gameEvent[2]);
		Military.impact = float.Parse(gameEvent[3]);
		Trade.impact = float.Parse(gameEvent[4]);
		Infrastructure.impact = float.Parse(gameEvent[5]);
	}
}
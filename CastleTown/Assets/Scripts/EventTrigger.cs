using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class EventTrigger:MonoBehaviour{

	private string[] gameEvent;
	private Text text;

    void Start(){
    	Invoke("Negative", Random.Range(10, 20));
    	Invoke("Positive", Random.Range(30, 60));
    }

	private void Negative(){
		gameEvent = Events.GetNeg();
        Impact();
        Invoke("Negative", Random.Range(10, 20));
	}

	private void Positive(){
		gameEvent = Events.GetPos();
        Impact();
        Invoke("Positive", Random.Range(30, 60));
	}

	private void Impact(){
		GetComponent<Text>().text = "* " + gameEvent[0] + "\n" + GetComponent<Text>().text + "\n";
		Health.impact = float.Parse(gameEvent[1]);
		Education.impact = float.Parse(gameEvent[2]);
		Military.impact = float.Parse(gameEvent[3]);
		Trade.impact = float.Parse(gameEvent[4]);
		Infrastructure.impact = float.Parse(gameEvent[5]);
	}
}
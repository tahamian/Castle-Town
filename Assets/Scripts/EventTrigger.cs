using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EventTrigger:MonoBehaviour{

	private string[] gameEvent;
    private string path = "Assets/Resources/data.txt";

    void Start(){
		Negative();
		Positive();
	}

	private void Negative(){
		gameEvent = Events.GetNeg();
        writer(gameEvent[0]);
        Impact();
		Invoke("Negative", Random.Range(5, 10));
	}

	private void Positive(){
		gameEvent = Events.GetPos();
        writer(gameEvent[0]);
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
    public void writer(string x)
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(x);
        writer.Close();

    }
}
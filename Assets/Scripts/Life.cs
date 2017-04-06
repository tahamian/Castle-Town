using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life:MonoBehaviour{

	private float averageLife;
	private float actualAverage;
	private float activeToggles;

	private ArrayList activeLives;

	private float[] allLives;
	private float min;

	private float eduLife;
	private float heaLife;
	private float infLife;
	private float milLife;
	private float traLife;

	public Toggle educationToggle;
	public Toggle healthToggle;
	public Toggle infrastructureToggle;
	public Toggle militaryToggle;
	public Toggle tradeToggle;

	public Text messages;
	public Text average;

	void Start(){
		averageLife = 100;
		actualAverage = 100;
		allLives = new float [5]{eduLife, heaLife, infLife, milLife, traLife};
		Average();
	}
	
	void Update(){
		eduLife = Education.eduLife;
	 	heaLife = Health.heaLife;
	  	infLife = Infrastructure.infLife;
	  	milLife = Military.milLife;
	  	traLife = Trade.traLife;
	  	allLives = new float [5]{eduLife, heaLife, infLife, milLife, traLife};
		CheckLoss();
	}

	public void CheckLoss(){
		min = Mathf.Min(allLives);

		if(min == 100) ShowMessage(" ");
		else if(eduLife == min) ShowMessage("Education needs attention.");
		else if(heaLife == min) ShowMessage("Health needs attention.");
		else if(infLife == min) ShowMessage("Infrastructure needs attention.");
		else if(milLife == min) ShowMessage("Military needs attention.");
		else if(traLife == min) ShowMessage("Trade needs attention.");

		if(actualAverage <= 0){
			ShowMessage("CastleTown has fallen.");
			Time.timeScale = 0;
		}
	}

	private void Average(){
		activeLives = new ArrayList();
		if(educationToggle.isOn) activeLives.Add(eduLife);
		if(healthToggle.isOn) activeLives.Add(heaLife);
		if(infrastructureToggle.isOn) activeLives.Add(infLife);
		if(militaryToggle.isOn) activeLives.Add(milLife);
		if(tradeToggle.isOn) activeLives.Add(traLife);
		
		activeToggles = activeLives.Count;
		for(int i = 0; i<activeToggles; i++) averageLife += (float)activeLives[i];
		averageLife = (int)(averageLife / (activeToggles + 1));
		if(averageLife <= 0) averageLife = 0;
		average.text = averageLife.ToString();
		for(int j = 0; j<5; j++) actualAverage += allLives[j];
		actualAverage = actualAverage / 5;
		Invoke("Average", 1);
	}

	private void ShowMessage(string msg){ messages.text = msg; }
}
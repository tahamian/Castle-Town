using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events:MonoBehaviour{

	private static string[][] negative = new string[][]{new string[]{"Attention, the black plague is spreading in Castletown.", "0.5",  "0.8", "0.7", "0.8", "0.9"},
						new string[]{"Attention, a plague of smallpox is spreading in Castletown.", "0.5" ,"0.8", "0.7", "0.8", "0.9"},
						new string[]{"Attention, the bubonic plague is spreading in Castletown.", "0.5", "0.8", "0.7", "0.8", "0.9"},
						new string[]{"Castletown's walls are under attack!", "0.5", "0.8", "0.5", "0.7", "0.8"},
						new string[]{"Castletown is under attack!", "0.5", "0.8", "0.5", "0.7", "0.8"},
						new string[]{"Inflation - prices are rising dramatically.", "0.7", "0.9", "0.7", "0.5", "0.8"},
						new string[]{"Castletown tokens are severely decreasing in worth.", "0.7", "0.9", "0.7", "0.5", "0.8"},
						new string[]{"Troops are needed for the upcomging war.", "0.3", "0.7", "0.3", "0.7", "0.7"},
						new string[]{"A war has been waged upon Castletown.", "0.3", "0.7", "0.3", "0.7", "0.7"},
						new string[]{"Local teachers are striking.", "1", "0.7", "1", "1", "1"},
						new string[]{"Castletown's military is on strike.", "1", "1", "0.7", "1", "1"},
						new string[]{"A famine has struck.", "0.5", "0.7", "0.7", "0.7", "0.7"},
						new string[]{"Castletown suffers a violent Earthquake.", "0.7", "0.7", "0.7", "0.7", "0.5"},
						new string[]{"A coup has taken place due to unemployment and high tariffs.", "1", "0.7", "0.7", "0.7", "0.7"}};

	private static string[][] positive = new string[][]{new string[]{"Deflation - prices are being lowered.", "1.3", "1.1", "1.3", "1.5", "1.2"},
						new string[]{"Castletown tokens are increasing in worth.", "1.3", "1.1", "1.3", "1.5", "1.2"},
						new string[]{"News: Local scientist wins a recognition award.", "1", "1.3", "1", "1", "1"},
						new string[]{"News: Local soldier has been knighted.", "1", "1", "1.3", "1", "1"},
						new string[]{"News: Local citizen has received accomodation from the king.","1.3", "1.3", "1.3", "1.3", "1.3"},
						new string[]{"Congratulations, Castletown has hit a milestone in trading!","1", "1", "1", "1.3", "1"},
						new string[]{"All citizens celebrating an excellent harvest season.", "1.3", "1", "1", "1.3", "1"},
						new string[]{"Harvest season celebrations are taking place.", "1.3", "1", "1", "1.3", "1"},
						new string[]{"Wow! Castletown is exhibiting an Engineering breakthrough.", "1", "1.3", "1.3", "1.3", "1.3"}};

	public static string[] GetNeg(){ return(negative[Random.Range(0, 13)]); }

	public static string[] GetPos(){ return(positive[Random.Range(0, 8)]); }
}
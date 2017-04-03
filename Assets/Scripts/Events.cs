using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events:MonoBehaviour{

	private static string[] negative = {"Attention, the black plague is spreading in Castletown.",
						"Attention, a plague of smallpox is spreading in Castletown.",
						"Attention, the bubonic plague is spreading in Castletown.",
						"Castletown's walls are under attack!",
						"Castletown is under attack!",
						"Inflation - prices are rising dramatically.",
						"Castletown tokens are severely decreasing in worth.",
						"Troops are needed for the upcomging war.",
						"A war has been waged upon Castletown.",
						"Local teachers are striking.",
						"Castletown's military is on strike.",
						"A famine has striked.",
						"Castletown suffers a violent Earthquake.",
						"Citizens are rioting due to unemployment and high tariffs."};

	private static string[] positive = {"Deflation - prices are being lowered.",
						"Castletown tokens are increasing in worth.",
						"News: Local scientist wins a recognition award.",
						"News: Local soldier has been knighted.",
						"News: Local citizen has received accomodation from the king.",
						"Congratulations, Castletown has hit a milestone in trading!",
						"All citizens celebrating an excellent harvest season.",
						"Harvest season celebrations are taking place.",
						"Wow! Castletown is exhibiting an Engineering breakthrough."};

	public static string GetNeg(){ return(negative[Random.Range(0, negative.Length)]); }

	public static string GetPos(){ return(positive[Random.Range(0, positive.Length)]); }
}
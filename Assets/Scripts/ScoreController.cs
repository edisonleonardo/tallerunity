using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ScoreController : MonoBehaviour {

	public Text ScoreText;
	public float TotalScore = 0;
	private GameObject[] cookies;
	public GameSettings Gsettings;


	// Use this for initialization
	void Start () {
		ScoreText.text = "Su puntaje es 0";
		cookies = GameObject.FindGameObjectsWithTag("cookie");
		foreach(GameObject cookie in cookies)
		{
			cookie.GetComponent<Cookie>().touched += HandleCookieTouched;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}




	void HandleCookieTouched ()
	{

		TotalScore+= Gsettings.StandarScore;
		ScoreText.text = "Su puntaje es " + TotalScore.ToString ();

	}


	public void HandleSuperCookieTouched()
	{
		
		TotalScore+=Gsettings.SpecialScore;
		ScoreText.text = "Su puntaje es " + TotalScore.ToString ();
		
	}
}

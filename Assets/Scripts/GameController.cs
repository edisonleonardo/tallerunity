using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {


	public GameObject superCookie;
	private GameObject activeSuperCookie;
	public ScoreController scoreC;
	public GameSettings gsettings;


	// Use this for initialization
	void Start () {
		StartCoroutine (SchedulecreateInstance());
	}
	
	IEnumerator ScheduleCoookieDestroy(){
		yield return new  WaitForSeconds (gsettings.cookieSpawnTime);
		Destroy (activeSuperCookie);
		StartCoroutine (SchedulecreateInstance ());
	}

	IEnumerator SchedulecreateInstance()
	{
		yield return new  WaitForSeconds (gsettings.cookieTimeLimit);
		activeSuperCookie = Instantiate (superCookie);
		activeSuperCookie.transform.position = gsettings.posiciones[Random.Range (0, gsettings.posiciones.Count)];
		activeSuperCookie.GetComponent<Cookie>().touched += scoreC.HandleSuperCookieTouched;
		StartCoroutine (ScheduleCoookieDestroy());
	}
}
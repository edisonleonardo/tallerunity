using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public GameObject superCookie;
	private GameObject activeSuperCookie;
	private bool created;
	// Use this for initialization
	void Start () {
		createInstance ();
		StartCoroutine (ScheduleCoookieDestroy ());
	}
	
	IEnumerator ScheduleCoookieDestroy(){
		yield return new  WaitForSeconds (3.0f);
		if (created) {
			destroyInstance();
		}else{
			createInstance();
		}
		StartCoroutine (ScheduleCoookieDestroy ());
	}

	private void createInstance()
	{
		activeSuperCookie = Instantiate (superCookie);
		created = true;
	}

	private void destroyInstance()
	{
		Destroy (activeSuperCookie);
		created = false;
	}
}

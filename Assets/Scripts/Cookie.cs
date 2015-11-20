using UnityEngine;
using System.Collections;

public class Cookie : MonoBehaviour {


	void OnTriggerEnter(Collider other)
	{
		gameObject.SetActive(false);
		Debug.Log("Algo me choco :D");
	}

}

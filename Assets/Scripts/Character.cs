using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	private Rigidbody rb;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// se llama la funcion fixedupdate en un tiempo fijo configurable, recomendado para llamar fisicas
	void FixedUpdate(){
		float moveHorizontal = max(Input.GetAxis("Horizontal"), Input.GetAxis("Mouse X"));
		float moveVertical = max(Input.GetAxis("Vertical"), Input.GetAxis("Mouse Y"));


		Vector3 movment = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movment * speed);

	}


	float max(float f1, float f2)
	{
		if (valorabsoluto(f1) > valorabsoluto(f2)) {
			return f1;
		} else {
			return f2;
		}
	}

	float valorabsoluto(float f1)
	{
		if (f1 < 0) {
			return f1 * -1;
		} else {
			return f1;
		}
	}

}

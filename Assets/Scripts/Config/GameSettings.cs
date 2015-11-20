using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


[Serializable]
public class GameSettings : ScriptableObject {
	public float cookieSpawnTime;
	public float cookieTimeLimit;
	public List<Vector3> posiciones;
	public float CharacterSpeed;
	public float StandarScore;
	public float SpecialScore;

}

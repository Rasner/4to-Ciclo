using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour {

	public float speed = 4f;
	public static SpeedManager instance;

	private void Awake() {
		
		instance = this;

	}

	public void Stop()
	{
		speed = 0;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

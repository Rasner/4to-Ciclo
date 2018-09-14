using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {

	public static Hazard instance;

	Transform enemy;

	void Awake() {

		instance = this;
		
	}

	// Use this for initialization
	void Start () {

		enemy = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

		enemy.transform.position += new Vector3(-SpeedManager.instance.speed,0,0) * Time.deltaTime; 
		if(enemy.transform.position.x < -7)
		{
			Destroy(this.gameObject);
		}
	}
}

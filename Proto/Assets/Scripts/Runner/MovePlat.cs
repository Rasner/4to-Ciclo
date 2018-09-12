using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlat : MonoBehaviour {

	public static MovePlat instance;
	Transform tPlat;
	//public float speed = 4f;
	public int value;

	private void Awake() {
		
		instance = this;

	}

	// Use this for initialization
	void Start () {

		tPlat = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

		tPlat.transform.position += new Vector3(-SpeedManager.instance.speed,0,0) * Time.deltaTime; 
		
	}
}

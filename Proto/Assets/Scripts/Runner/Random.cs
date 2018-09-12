using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour {

	public GameObject Enemy;
	public GameObject Hazard;
	private int Value;

	// Use this for initialization
	void Start () {

		Value = UnityEngine.Random.Range(0,2);	

		switch(Value)
		{
			case 0:
			Instantiate(Enemy, gameObject.transform.position, gameObject.transform.rotation);
			break;

			case 1:
			Instantiate(Hazard, gameObject.transform.position, gameObject.transform.rotation);
			break;
		}	
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}

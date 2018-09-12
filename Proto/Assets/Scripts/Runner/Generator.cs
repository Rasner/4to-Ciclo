using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public static Generator instance;
	public GameObject[] Templates;
	public Transform startingPos;
	public GameObject firstPos;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {

		startingPos.position = firstPos.transform.position;

		GameObject tile = Instantiate(Templates[UnityEngine.Random.Range(0,Templates.Length)], startingPos.position, startingPos.transform.rotation);

		startingPos = tile.transform.Find("Spawn");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NewTemplate()
	{
		GameObject tile = Instantiate(Templates[UnityEngine.Random.Range(0,Templates.Length)], startingPos.position, startingPos.transform.rotation);

		startingPos = tile.transform.Find("Spawn");
	}
}

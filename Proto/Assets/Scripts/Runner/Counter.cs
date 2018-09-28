using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

	public Text Coins;

	public int Score;

	public static Counter instance;

	void Awake()
	{
		instance = this;	
	}

	// Use this for initialization
	void Start () {

        Score = GlobalControl.Instance.Score;
		
	}
	
	// Update is called once per frame
	void Update () {

		Coins.text = "x " + Score.ToString();
        if (Score < 0)
        {
            Score = 0;
        }
	}
}

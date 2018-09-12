using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour {

	Animator anim;

	public static Transition instance;

	void Awake() {

		instance = this;
		
	}

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

		
		
	}
	public void Play()
	{
		anim.Play("Transition");
	}

	public void EndAnim()
	{
		SceneManager.LoadScene(1);
        Destroy(this.gameObject);
	}
}

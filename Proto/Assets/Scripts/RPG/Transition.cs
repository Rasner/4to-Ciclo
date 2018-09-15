using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour 
{
	private Animator anim;
	
	public static Transition instance;

	private AsyncOperation loadingOP;

	void OnEnable()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () 
	{
		loadingOP = null;
		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

		
		
	}
	public void Play()
	{
		Color c = GetComponent<Image>().color;
		c.a = 1;
		GetComponent<Image>().color = c;
		anim.SetTrigger("transition");
		loadingOP = SceneManager.LoadSceneAsync(1);
		loadingOP.allowSceneActivation = false;
	}

	public void EndAnim()
	{
		Color c = GetComponent<Image>().color;
		c.a = 0;
		GetComponent<Image>().color = c;
		loadingOP.allowSceneActivation = true;
	}
}

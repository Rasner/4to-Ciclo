using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Swipe : MonoBehaviour {

	Vector3 firstPressPos;
	Vector3 secondPressPos;
	Vector3 currentSwipe;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		DoSwipe();
		
	}

	public void DoSwipe()
	{
		if(Input.GetMouseButtonDown(0))
		{
			firstPressPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
		}

		if(Input.GetMouseButtonUp(0))
		{
			secondPressPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);

			currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

			currentSwipe.Normalize();

			if(currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
			{
				Debug.Log("Up");
				PlayerRunner.instance.Up();
			}

			if(currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
			{
				Debug.Log("Down");
				PlayerRunner.instance.Down();
			}
		}
	}
}

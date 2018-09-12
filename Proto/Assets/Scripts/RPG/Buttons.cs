using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectionAttack(int x)
    {
        UImanage.instance.A_button = x;
    }

    public void SelectionShield(bool s)
    {
        UImanage.instance.S_button = s;
    }
}

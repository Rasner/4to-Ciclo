﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanage : MonoBehaviour {

    public static UImanage instance;
    public Slider PTurn;
    public Slider ETurn;
    public int A_button;
    public bool Pcombat;
    public bool Ecombat;
    public bool Pcasting;
    public bool Ecasting;
    public bool S_button;
    // Use this for initialization
    void Start() {
       
        instance = this;
        PTurn.value = 0;
        ETurn.value = 0;
        Pcombat = false;
        Ecombat = false;
        S_button = false;
        A_button = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Turn();
        //EnemyTurn();
	}

    void OnPlayerTurnEnd()
    {
        if (Pcasting == false)
        {
            Pcombat = true;
            Debug.Log("combatefalso");
            //A_button = 0;
            Pcombat = false;
        }
    }

    void OnEnemyTurnEnd()
    {
        if (Ecasting == false)
        {
            Ecombat = true;
            Debug.Log("combatefalso");
            //A_button = 0;
            Ecombat = false;
        }
    }

    public void Turn()
    {
        if (PTurn.value < 1)
        {
            PTurn.value += 0.0060f;
            Pcasting = (PTurn.value < 1 && PTurn.value > 0.8) ? true : false;
        }

        else if (PTurn.value == 1)
        {
            PTurn.value = 0;
            OnPlayerTurnEnd();
        }

        if (ETurn.value < 1)
        {
            ETurn.value += 0.0055f;
            Ecasting = (ETurn.value < 1 && ETurn.value > 0.8) ? true : false;
        }
        else if (ETurn.value == 1)
        {
            OnEnemyTurnEnd();
            ETurn.value = 0;
        }
    }
}

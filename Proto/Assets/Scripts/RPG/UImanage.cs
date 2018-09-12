using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanage : MonoBehaviour {

    public static UImanage instance;
    public int A_button;
    public bool combat;
    public bool casting;
    public bool S_button;
    // Use this for initialization
    void Start() {
        instance = this;
        combat = false;
        S_button = false;
        A_button = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("pressT");
            StartCoroutine(OnTurnEnd());
        }
	}

    public void EndTurn()
    {
        StartCoroutine(OnTurnEnd());
    }

    IEnumerator OnTurnEnd()
    {
        casting = true;
        Debug.Log("casting start");
        yield return new WaitForSeconds(1);
        casting = false;
        if (casting == false && combat == false)
        {
            combat = true;
            yield return new WaitForSeconds(0.1f);
            Debug.Log("combatefalso");
            A_button = 0;
            combat = false;
        }
    }
}

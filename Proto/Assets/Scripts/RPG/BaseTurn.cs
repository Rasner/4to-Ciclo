using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseTurn : MonoBehaviour {

    public Slider PlayerT;
    public float barraTurno;
	// Use this for initialization
	void Start () {
        PlayerT.value = 0;
	}
	
	// Update is called once per frame
	void Update() { 
        //if (Input.GetKeyDown(KeyCode.A))
        barraTurnoOn();
	}

    public void barraTurnoOn()
    {
        PlayerT.value = (PlayerT.value == 1) ? PlayerT.value = 0 : PlayerT.value += 0.01f;
        Debug.Log(PlayerT.value);
    }

/*IEnumerator coldownbarra()
    {

    }
    */
}

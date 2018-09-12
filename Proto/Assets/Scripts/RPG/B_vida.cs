using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_vida : MonoBehaviour {

    public Image barra_r;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Player.instance.dañado == true)
        {
            ActualizarBarra();
        }
    }

    public void ActualizarBarra()
    {
        Vector3 scale = barra_r.transform.localScale;
        scale.x = (Player.instance.VidaAc / 100);
        barra_r.transform.localScale = scale;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public const int VidaFull = 100;
    public int VidaAc;
    public Material ondmg;
    public Material standar;
    public Material casting;
    public bool dañado;
    // Use this for initialization
    void Start()
    {
        VidaAc = VidaFull;
        dañado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (UImanage.instance.combat == true && dañado == false)
        {
            dañado = true;
            switch (UImanage.instance.A_button)
            {
                case 1:
                    VidaAc -= 10;
                    break;
                case 2:
                    VidaAc -= 20;
                    break;
                case 3:
                    VidaAc -= 30;
                    break;
                default: break;
            }
            if (UImanage.instance.A_button != 0)
            {
                OnDamageTaken();
            }
        }
        if (VidaAc <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    
    void OnDamageTaken()
    {
        StartCoroutine(color());
    }

    IEnumerator color()
    {
        gameObject.GetComponent<Renderer>().material = ondmg;
        yield return new WaitForSeconds(0.5f);
        dañado = false;
        gameObject.GetComponent<Renderer>().material = standar;
    }
}

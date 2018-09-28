using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        if (UImanage.instance.PTurn.value == 1)
        {
            if (UImanage.instance.A_button != 0)
            {
                OnDamageTaken();
            }
        }
        if (VidaAc <= 0)
        {
           
            SceneManager.LoadScene(0);

        }
    }
    
    void OnDamageTaken()
    {
        StartCoroutine("color");
    }

    IEnumerator color()
    {
        gameObject.GetComponent<Renderer>().material = ondmg;
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
        dañado = true;
        yield return new WaitForSeconds(0.5f);
        dañado = false;
        gameObject.GetComponent<Renderer>().material = standar;
    }
}

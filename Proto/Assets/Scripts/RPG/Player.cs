using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player instance;
    public const int VidaFull = 100;
    public int VidaAc;
    public Material ondmg;
    public Material standar;
    public Material onshield;
    public bool shielding;
    public bool dañado;
    // Use this for initialization
    void Start()
    {
        instance = this;
        VidaAc = VidaFull;
        shielding = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("space"))
        {
            OnDamageTaken();
        }
        */
        if (UImanage.instance.S_button && !shielding)
        {
            shielding = true;
            OnShieldActive();
            UImanage.instance.S_button = false;
        }

        if (UImanage.instance.Ecombat == true && shielding == false && dañado == false)
        {
            dañado = true;
            OnDamageTaken();
        }

        else if (UImanage.instance.Pcasting == true && shielding == true)
        {
            Debug.Log("bloqueado");
        }

        if (VidaAc <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void OnDamageTaken()
    {
        StartCoroutine(Damage());
    }

    void OnShieldActive()
    {
        StartCoroutine(Shield());
    }

    IEnumerator Shield()
    {
        gameObject.GetComponent<Renderer>().material = onshield;
        yield return new WaitForSeconds(0.3f);
        shielding = false;
        gameObject.GetComponent<Renderer>().material = standar;
    }

    IEnumerator Damage()
    {
        gameObject.GetComponent<Renderer>().material = ondmg;
        VidaAc -= UnityEngine.Random.Range(5, 12);
        Debug.Log("Player dañado");
        Debug.Log(VidaAc);
        yield return new WaitForSeconds(0.5f);
        dañado = false;
        gameObject.GetComponent<Renderer>().material = standar;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player instance;
    public Material ondmg;
    public Material standar;
    public Material onshield;
    public bool shielding;
    // Use this for initialization
    void Start()
    {
        instance = this;
        shielding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (UImanage.instance.S_button == true && shielding == false)
        {
            shielding = true;
            OnShieldActive();
            UImanage.instance.S_button = false;
        }
        if (UImanage.instance.ETurn.value == 1)
        {
            LifeBar.instance.DealDamage(10);
            OnDamageTaken();
        }
        else if (UImanage.instance.Ecasting == true && shielding == true)
        {
            //Debug.Log("bloqueado");
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
        Debug.Log("Player dañado");
        
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Renderer>().material = standar;
    }

}

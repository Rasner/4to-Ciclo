using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {

    public float HP;
    public int Score;
    void Start()
    {
       HP = GlobalControl.Instance.CurrentHealth = HP;
       Score = GlobalControl.Instance.Score = Score;
    }
    public void SavePlayer()
    {
        GlobalControl.Instance.CurrentHealth = HP;
        GlobalControl.Instance.Score = Score;
        
    }
}

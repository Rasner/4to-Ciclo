using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    public float CurrentHealth;
    public int Score;
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        Score = 0;
        CurrentHealth = 100;
    }

    private void Update()
    {
        Score = Counter.instance.Score;
        CurrentHealth = LifeBar.instance.CurrentHealth;
    }
}
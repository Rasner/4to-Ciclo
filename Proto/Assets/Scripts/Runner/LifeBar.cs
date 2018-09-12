using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour {

	public static LifeBar instance;

	public float CurrentHealth {get; set;}
	public float MaxHealth {get; set;} 	
	public Slider healthBar;


	void Awake() {

		instance = this;
		
	}

	// Use this for initialization
	void Start () {

		MaxHealth = 100f;
		CurrentHealth = MaxHealth;

		healthBar.value = CalculateHealth();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.X))
		{
			DealDamage(30);
		}
	}

	public void DealDamage(float damageValue)
	{
		CurrentHealth -= damageValue;
		healthBar.value = CalculateHealth();

		if(CurrentHealth <= 0)
		{
			Die();
		}
	}

	float CalculateHealth()
	{
		return CurrentHealth / MaxHealth
;	}

	void Die()
	{
		CurrentHealth = 0;
        Destroy(this.gameObject);
	}
}

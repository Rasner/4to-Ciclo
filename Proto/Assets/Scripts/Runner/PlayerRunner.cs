using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRunner : MonoBehaviour {

	Rigidbody rb;
	Transform t;
	public bool grounded;
	public bool sliding;

	public static PlayerRunner instance;
	
	public float gravityScale = 1.0f;
	public float gravityValue = -9.81f;


	void Awake() {

		instance = this;
		
	}

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
		t = GetComponent<Transform>();
		grounded = true;
	}

	void FixedUpdate() {

		Vector3 Gravity =gravityValue * gravityScale * Vector3.up;
		rb.AddForce(Gravity, ForceMode.Acceleration);
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.UpArrow) && grounded == true)
		{
			rb.velocity = new Vector3(rb.velocity.x, 7.7f, rb.velocity.z);
			grounded = false; 
		}
		
		if(Input.GetKeyDown(KeyCode.DownArrow) && grounded == true && sliding == false)
		{
			StopCoroutine("Slide");
			StartCoroutine("Slide");
			t.transform.rotation = Quaternion.Euler(0,0,90);
			t.transform.position = new Vector3(t.transform.position.x,(t.transform.position.y)-0.35f,0);
			sliding = true;
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow) && grounded == false && sliding == false)
		{
			rb.velocity = new Vector3(rb.velocity.x, -7.5f, rb.velocity.z);	
		}
	}

	public void Up()
	{
		if(grounded == true)
		{
			rb.velocity = new Vector3(rb.velocity.x, 11f, rb.velocity.z);
			grounded = false; 
		}
	}

	public void Down()
	{
		if(grounded == true && sliding == false)
		{
			StopCoroutine("Slide");
			StartCoroutine("Slide");
			t.transform.rotation = Quaternion.Euler(-180,90,0);
			t.transform.position = new Vector3(t.transform.position.x,(t.transform.position.y)-0.35f,0);
			sliding = true;
		}
		else if(grounded == false && sliding == false)
		{
			rb.velocity = new Vector3(rb.velocity.x, -7.5f, rb.velocity.z);	
		}
	}

	IEnumerator Slide()
	{
		if(sliding == true)
		{
			yield return null;
		}

		yield return new WaitForSeconds(0.6f);

		t.transform.rotation = Quaternion.Euler(-90,90,0);
		t.transform.position = new Vector3(t.transform.position.x,(t.transform.position.y)+0.35f,0);
		sliding = false;
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Platform")
		{
			grounded = true;
		}		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Hazard")
		{
			LifeBar.instance.DealDamage(25);
		}
		
		if(other.gameObject.tag == "Enemy")
		{
			SpeedManager.instance.Stop();
			Transition.instance.Play();
		}	

		if(other.gameObject.tag == "Coin")
		{
			GameObject.Find("Counter Text").GetComponent<Counter>().Score += 1;
			Destroy(other.gameObject);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Tile")
		{
		Destroy(other.gameObject,1.5f);
		Generator.instance.NewTemplate();
		}
	}
}

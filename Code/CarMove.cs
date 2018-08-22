using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour {

	float Speed;
	GameObject FindScript;
	
	// Use this for initialization
	void Start () {
		FindScript = GameObject.Find("Main Camera");
		Speed = FindScript.GetComponent<GoToMenu>().CarBlockSpeed;
	}
	
	// Update is called once per frame
	void Update () {

		Speed = FindScript.GetComponent<GoToMenu>().CarBlockSpeed;
		transform.position += new Vector3(-Speed * Time.deltaTime, 0, 0);
	}

	void OnTriggerEnter(Collider other)
	{
		this.gameObject.SetActive(false);
	}
}

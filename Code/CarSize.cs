using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSize : MonoBehaviour {

	float SizeMin = 1;
	float SizeMax = 5;
	public float Size;
	// Use this for initialization
	void Start () {

		Size = Random.Range(SizeMin, SizeMax);//Random
		transform.localScale = new Vector3(Size, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {

		

	}
}

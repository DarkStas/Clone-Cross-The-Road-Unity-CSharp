using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pools;

public class SpawnAfterCar : MonoBehaviour {

	GameObjectPool FindScript;
	int ThisZ;
	float SizeMin = 1;
	float SizeMax = 5;
	float NextSize;
	float ThisSize;
	float Distance;
	float ForCalc = 0;
	float DistanceXForCalc = 0;
	float calcX;
	float ThisX;
	bool OneTimePerEnable;


	// Use this for initialization
	void Start () {
		
	}

	private void OnEnable()
	{
		OneTimePerEnable = false;
		FindScript = GameObject.Find("Main Camera").GetComponent<SpawnFromPool>().ObjPull;
		ThisZ = (int)this.gameObject.transform.position.z;
		ThisSize = this.gameObject.transform.localScale.x;
		NextSize = Random.Range(SizeMin, SizeMax);//Random
		ForCalc = (NextSize / 2) + 4 + (ThisSize / 2);
		Distance = Random.Range(ForCalc, ForCalc + 8);//Random
		DistanceXForCalc = Distance + (NextSize / 2);
	}

	// Update is called once per frame
	void Update () {

		ThisX = this.gameObject.transform.position.x;
		calcX = ThisX + DistanceXForCalc;

		if (calcX <= 47 && !OneTimePerEnable)
		{
			
			FindScript.Spawn(new Vector3(ThisX + Distance, 0, 0 + (ThisZ)), Quaternion.identity, new Vector3(NextSize, 1, 1));
			OneTimePerEnable = true;
		}
	}
}

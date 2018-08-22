using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pools;

public class SpawnFromPool : MonoBehaviour {

	[HideInInspector]
	public GameObjectPool ObjPull;
	public GameObject ObjPrefab;
	float SizeMin = 1;
	float SizeMax = 5;
	float Size;
	float NextZ = 5f;
	GameObject FindObj1;
	float EndSpawnZ;
	
	// Use this for initialization
	void Start()
	{
		FindObj1 = GameObject.Find("Trigger (3)");
		ObjPull = new GameObjectPool(ObjPrefab, 99, ObjHandler, true);
		ObjPull.prePopulate(99);
		for (int y = 1; y < 10; y++)
		{
				Size = Random.Range(SizeMin, SizeMax);//Random
				ObjPull.Spawn(new Vector3(-40, 0, NextZ), Quaternion.identity, new Vector3(Size,1,1));
				NextZ += 6;
		}
	}

	void ObjHandler(GameObject target)
	{
		target.name = "Car";
	}

	// Update is called once per frame
	void Update () {
		EndSpawnZ = FindObj1.gameObject.transform.position.z;
		if(NextZ + 6 <= EndSpawnZ)
		{
			Size = Random.Range(SizeMin, SizeMax);//Random
			ObjPull.Spawn(new Vector3(-5, 0, 0 + NextZ), Quaternion.identity, new Vector3(Size, 1, 1));
			NextZ += 6;
		}
	}
}
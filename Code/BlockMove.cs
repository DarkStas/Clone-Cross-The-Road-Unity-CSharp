using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockMove : MonoBehaviour {

	public Text GameOver;
	GameObject FindCamera;

	// Use this for initialization
	void Start()
	{
		FindCamera = GameObject.Find("Main Camera");
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
		{
			transform.position += new Vector3(0, 0, 1);
			FindCamera.GetComponent<GoToMenu>().GameScore += 1;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		StartCoroutine(GameOverText());
	}

	IEnumerator GameOverText()
	{
		GameOver.gameObject.SetActive(true);
		yield return new WaitForSeconds(1);
		GameOver.gameObject.SetActive(false);
	}
}

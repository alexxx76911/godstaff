using UnityEngine;
using System.Collections;

public class guiText1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<GUIText>().fontSize = 50;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CameraC.loses >=0)
		GetComponent<GUIText>().text = "Losses: " + CameraC.loses;
		else
			GetComponent<GUIText>().text = "Losses: " + 0;

		if (CameraC.h1 == true) {
			CameraC.h1 = false;
			StartCoroutine (respawnWait ());
			
		}

		if (CameraC.h2 == true) {
						CameraC.h2 = false;
						StartCoroutine (respawnWait1 ());
				}
	}

	IEnumerator respawnWait()
	{
		GetComponent<GUIText>().color = Color.red;
		yield return new WaitForSeconds (0.2f);
		GetComponent<GUIText>().color = Color.white;
	}

	IEnumerator respawnWait1()
	{
		GetComponent<GUIText>().color = Color.green;
		yield return new WaitForSeconds (0.2f);
		GetComponent<GUIText>().color = Color.white;
	}

}

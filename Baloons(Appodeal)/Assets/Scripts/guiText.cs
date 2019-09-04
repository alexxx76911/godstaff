using UnityEngine;
using System.Collections;

public class guiText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<GUIText>().fontSize = 50;

	}
	
	// Update is called once per frame
	void Update () {
		if (CameraC.h == true) {
			CameraC.h = false;
						StartCoroutine (respawnWait ());

				}

		GetComponent<GUIText>().text = "Balloons: " + CameraC.baloons;

	}

	IEnumerator respawnWait()
	{
		GetComponent<GUIText>().color = Color.green;
		yield return new WaitForSeconds (0.2f);
		GetComponent<GUIText>().color = Color.white;
	}
}

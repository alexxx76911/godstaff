using UnityEngine;
using System.Collections;

public class record : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<GUIText>().text = "Your Record: " + CameraC.record;
		GetComponent<GUIText>().fontSize = 70;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

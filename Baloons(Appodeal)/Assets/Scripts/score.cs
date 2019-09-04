using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<GUIText>().text = "Balloons: " + CameraC.baloons;
		GetComponent<GUIText>().fontSize = 70;
	
	}
}

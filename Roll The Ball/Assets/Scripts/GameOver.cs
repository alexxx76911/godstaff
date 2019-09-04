using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	private Text record;
	private Text distance;

	// Use this for initialization
	void Start () {
		record = GetComponentInChildren<Text> ();



	
	}
	
	// Update is called once per frame
	void Update () {

		record.text = "Your Record: " + gameManager.record;
	
	}
}

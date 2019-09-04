using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistGameOver : MonoBehaviour {

	private Text dist; 

	// Use this for initialization
	void Start () {
		dist = GetComponent<Text> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		dist.text = "Distance: " + gameManager.dist;
	
	}
}

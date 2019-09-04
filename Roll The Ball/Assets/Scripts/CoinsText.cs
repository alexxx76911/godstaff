using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinsText : MonoBehaviour {

	private Text coinsText; 

	// Use this for initialization
	void Start () {
		coinsText = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		coinsText.text = "Coins: " + gameManager.coins;
	
	}
}

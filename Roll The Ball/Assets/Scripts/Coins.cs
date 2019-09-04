using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour {

	public GameObject coineff;



	void OnTriggerEnter (Collider other)
	{
		gameManager.coinSound = true;
		Instantiate (coineff, transform.position, transform.rotation);
		gameManager.coins += 1;
		Destroy (gameObject);

	}



}

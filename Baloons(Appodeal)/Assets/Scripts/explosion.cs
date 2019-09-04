using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	void LateUpdate()
	{
		if (!GetComponent<ParticleSystem>().IsAlive())
			Destroy (gameObject);
	}




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  
	}
}

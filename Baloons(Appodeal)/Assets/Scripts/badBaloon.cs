using UnityEngine;
using System.Collections;

public class badBaloon : MonoBehaviour {
	public GameObject fail;
	public GameObject x;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * CameraC.speed * Time.deltaTime);
		
		if (transform.position.y > 6.5f) 
			Destroy (gameObject);
		
		
		if (transform.position.x == 20f) {
			Instantiate (x, CameraC.m1, transform.rotation);
			CameraC.h1 = true;
			if(cameraMainMenu.sfx)
			   Instantiate (fail, transform.position, transform.rotation);
			Destroy (gameObject);
			CameraC.loses -= 1;
		}
	}
}

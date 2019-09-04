using UnityEngine;
using System.Collections;

public class snow : MonoBehaviour {
	public GameObject boomSnow;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * CameraC.speed * Time.deltaTime);

		if (transform.position.y > 6.5f) 
			Destroy (gameObject);

		if (transform.position.x == 20f) {
			CameraC.h4 = true;
			CameraC.h5 = true;
			CameraC.h6 = true;
			if(cameraMainMenu.sfx)
			   Instantiate (boomSnow, transform.position, transform.rotation);
			Destroy (gameObject);
				}
	}
}

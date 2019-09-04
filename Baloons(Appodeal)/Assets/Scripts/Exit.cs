using UnityEngine;
using System.Collections;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class Exit : MonoBehaviour {

	private float speed;
	private float t;
	private float b;
	public GameObject boomBaloon;

	
	
	// Use this for initialization
	void Start () {
		speed = 0.5f;
		t = 0;
		b = 0.4f;

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * speed * Time.deltaTime);
		
		if (Time.timeSinceLevelLoad >= t + b) {
			speed *= -1;
			t = Time.timeSinceLevelLoad;
			
		}
		
		if (transform.position.x == 20) {
			Appodeal.showWithPriceFloor (Appodeal.INTERSTITIAL);
			cameraMainMenu.v = true;
			cameraMainMenu.v2 = true;
			CameraC.h7 = true;
			CameraC.h8 = true;
			GameOver.v = true;
			GameOver.v2 = true;

			if(cameraMainMenu.sfx)
			   Instantiate (boomBaloon, transform.position, transform.rotation);
			Destroy(gameObject);
			
		}

		if (CameraC.h3 == true)
						Destroy (gameObject);
	}
	
}

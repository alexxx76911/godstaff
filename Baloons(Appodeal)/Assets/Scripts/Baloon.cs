using UnityEngine;
using System.Collections;

public class Baloon : MonoBehaviour {
	public GameObject explosion;
	public GameObject boomBaloon;
	public GameObject fail;
	public GameObject text;



	

	// Update is called once per frame
	void Update () {

		transform.Translate (Vector2.up * CameraC.speed * Time.deltaTime);
			 
		if (transform.position.x == 20) {
			CameraC.h = true;

			if(cameraMainMenu.sfx)
			   Instantiate (boomBaloon, transform.position, transform.rotation);

			Instantiate (text, CameraC.m1, transform.rotation);
			Destroy (gameObject);
			CameraC.baloons +=1;
				}
				
	
		if (transform.position.y > 5.335308f) {
			CameraC.h1 = true;
				CameraC.loses -= 1;
			if(cameraMainMenu.sfx)
			   Instantiate (fail, transform.position, transform.rotation);
			Destroy(gameObject);
				}

		if (CameraC.s.x == 20f) {
						if (transform.position.y > -5.00709) {
				                Instantiate (text, transform.position, transform.rotation);
								Destroy (gameObject);
								CameraC.baloons += 1;
				                explosion.transform.position = transform.position;
				                Instantiate (explosion,   explosion.transform.position, explosion.transform.rotation);  
						}
				}
				
	





	
	}
}


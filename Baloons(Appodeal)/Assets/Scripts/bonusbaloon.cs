using UnityEngine;
using System.Collections;

public class bonusbaloon : MonoBehaviour {
	public GameObject bonus;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector2.up * CameraC.speed * Time.deltaTime);

		if (transform.position.y > 6.5f) 
						Destroy (gameObject);
				
		
		if (transform.position.x == 20f) {
			CameraC.h2 = true;
			if(cameraMainMenu.sfx)
			   Instantiate (bonus, transform.position, transform.rotation);
						Destroy (gameObject);
						CameraC.loses += 1;
				}

	}
}

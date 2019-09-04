using UnityEngine;
using System.Collections;

public  class bombBaloon : MonoBehaviour {

	public GameObject boomBomb;




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * CameraC.speed * Time.deltaTime);

		
		if (transform.position.x == 20f) {
			if(cameraMainMenu.sfx)
			   Instantiate (boomBomb, transform.position, transform.rotation);
			CameraC.s = transform.position;
			Destroy(gameObject);
			CameraC.i1 = 0;
		}
		
		
		if (transform.position.y > 6.5f) {
			Destroy(gameObject);
		}
	}

   
}

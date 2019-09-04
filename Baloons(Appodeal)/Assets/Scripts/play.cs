using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {
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
			            cameraMainMenu.v = true;
		                cameraMainMenu.v1 = true;
			            GameOver.v = true;
			            GameOver.v1 = true;
			            if(cameraMainMenu.sfx)
			               Instantiate (boomBaloon, transform.position, transform.rotation);



			            
			Destroy(gameObject);
						
			}
	}

}

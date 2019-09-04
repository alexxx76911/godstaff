using UnityEngine;
using System.Collections;

public class superBaloon : MonoBehaviour {
	public GameObject boomBaloon;
	public GameObject text1;
	public int bal;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * CameraC.speed * Time.deltaTime);
	    if (transform.position.x == 20f) {
			if(cameraMainMenu.sfx)
			   Instantiate (boomBaloon, transform.position, transform.rotation);
			Instantiate (text1, CameraC.m1, transform.rotation);
			CameraC.baloons += bal;
			Destroy(gameObject);
		}

	}
}

using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (CameraC.h3 == true) {
			CameraC.h3 = false;
						Destroy (gameObject);
			     
				}
	}
}

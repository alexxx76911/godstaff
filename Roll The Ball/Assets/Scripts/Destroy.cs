using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {





	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {





			if (transform.position.z <= gameManager.cameraPos.z - 40) 
			{

				gameManager.isDestroy = true;
				Destroy (gameObject);
			}

	
	}
}

using UnityEngine;
using System.Collections;

public class text : MonoBehaviour {
	private int i;


	IEnumerator Fade() {
		for (float f = 1f; f >= 0; f -= 0.01f) {
			Color c = GetComponent<Renderer>().material.color;
			c.a = f;
			GetComponent<Renderer>().material.color = c;
			yield return null;
		}
	}





	// Use this for initialization
	void Start () {
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine ("Fade");
		if (i == 100) 
						Destroy (gameObject);

				
		i++;
		
		}
}

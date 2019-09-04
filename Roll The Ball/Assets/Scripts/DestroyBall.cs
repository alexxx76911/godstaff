using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {
	private float x, y, z;
	private Vector3 newScale;

	void Start()
	{
		x = 0.7f;
		y = 0.7f;
		z = 0.7f;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= -20) 
		{
			if (transform.position.z >= 100)
				Social.ReportProgress("CgkIwfPExPwLEAIQAw", 100.0f, (bool success) => {
					// handle success or failure
				});

			if (transform.position.z >= 500)
				Social.ReportProgress("CgkIwfPExPwLEAIQBA", 100.0f, (bool success) => {
					// handle success or failure
				});

			if (transform.position.z >= 1000)
				Social.ReportProgress("CgkIwfPExPwLEAIQBQ", 100.0f, (bool success) => {
					// handle success or failure
				});

			if (transform.position.z >= 1500)
				Social.ReportProgress("CgkIwfPExPwLEAIQBg", 100.0f, (bool success) => {
					// handle success or failure
				});

			if (transform.position.z >= 3000)
				Social.ReportProgress("CgkIwfPExPwLEAIQBw", 100.0f, (bool success) => {
					// handle success or failure
				});

			if (transform.position.z >= 5000)
				Social.ReportProgress("CgkIwfPExPwLEAIQCA", 100.0f, (bool success) => {
					// handle success or failure
				});
			if (transform.position.z > gameManager.record) 
			{
				gameManager.record = (int)transform.position.z;
				PlayerPrefs.SetInt ("record", gameManager.record);
			}

			gameManager.dist = (int) transform.position.z;

			if(Social.localUser.authenticated)
			Social.ReportScore(gameManager.dist, "CgkIwfPExPwLEAIQAA", (bool success) => {
				// handle success or failure
			});

			Destroy (gameObject);
		}

		if (transform.position.y <= -0.3) 
		{
			x -= 0.01f;
			y -= 0.01f;
			z -= 0.01f;
			newScale.Set (x, y, z);
		    transform.localScale = newScale;
		}
	
	}
}

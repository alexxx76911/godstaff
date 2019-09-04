using UnityEngine;
using System.Collections;
//using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Leaders : MonoBehaviour {
	private float speed;
	private float t;
	private float b;
	private float timer;
	private Vector3 oldPosition;
	private bool isBoom;
	public GameObject boomBaloon;


	// Use this for initialization
	void Start () {
		speed = 0.5f;
		t = 0;
		b = 0.4f;
		timer = 0;
		oldPosition = transform.position; 
		isBoom = false;

	    
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * speed * Time.deltaTime);
		
		if (Time.timeSinceLevelLoad >= t + b) {
			speed *= -1;
			t = Time.timeSinceLevelLoad;
			
		}

		if (transform.position.x == 20) 
		{
			if (!isBoom)
			{
				if(cameraMainMenu.sfx)
			       Instantiate (boomBaloon, transform.position, transform.rotation);
				isBoom = true;
			}
			timer += Time.deltaTime;

			if (timer>=1)
			{
				timer = 0;
				//PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIhYz47rgREAIQAQ");
				transform.position = oldPosition;
				isBoom = false;

			}



	
	    }
  }


}

using UnityEngine;
using System.Collections;
//using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;


public class GameOver : MonoBehaviour {
	private Ray ray;
	private RaycastHit hit;
	Vector2 m = new Vector2(20f, 4f);
	public  GameObject explosion;
	private float t, b;
	public static bool v, v1, v2;
	float timer;
	bool ShowAd;
	private int video;

	
	// Use this for initialization
	void Start () {
		//if (NoAds.ads == 0) 
		//{
		 //  video = PlayerPrefs.GetInt ("video");
		 //  video += 1;
		  // PlayerPrefs.SetInt("video",video);


						


			//	Appodeal.show(Appodeal.BANNER_BOTTOM);	
		//}



		timer = 0;
		ShowAd = true;



		v = false;
		v1 = false;
		v2 = false;
		t = 0;
		b = 1;


	}
	
	// Update is called once per frame
	void Update () {




		timer += Time.deltaTime;

		if (timer >= 3 && ShowAd) 
		{
			//if (NoAds.ads == 0)
			//{
				if (video == 5) 
				{
					if (Appodeal.isLoaded(Appodeal.VIDEO))
					    {
					video = 0;
					PlayerPrefs.SetInt ("video", video);

					Appodeal.show (Appodeal.VIDEO);
					ShowAd = false;
					    }
				}
			else
				{
					if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
					{
				    ShowAd = false;
				
					Appodeal.showWithPriceFloor (Appodeal.INTERSTITIAL);
					}
				}
			//}
		}

		if (Input.GetMouseButtonDown(0)) {
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, 100)) {
				
				Instantiate(explosion, hit.transform.position, hit.transform.rotation);
				hit.transform.position = m;
			}
			
		}
		
		
		
		if (v == true) { 
			v = false;
			t = Time.timeSinceLevelLoad;
		}
		
		
		if (v1 == true) {
			if (Time.timeSinceLevelLoad >= t + b){
				v1 = false;
				Application.LoadLevel ("Game");
			}
		}
		
		if (v2 == true) {
			if (Time.timeSinceLevelLoad >= t + b)
				Application.Quit ();
		}
		
		
	}
	
	
	
}


using UnityEngine;
using System.Collections;
//using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;






public class cameraMainMenu : MonoBehaviour {
	private Ray ray;
	private RaycastHit hit;

	Vector2 m = new Vector2(20f, 4f);
	public  GameObject explosion;
	private float t, b;
	public static bool v, v1, v2;
	public GameObject  canvas, balloonFun;
	public static bool sfx, ad;



	void Awake()
	{
		string appKey = "75524dbb119c7a095779257bda416e2bc33c7d2ee8e99bd9";
		Appodeal.initialize(appKey, Appodeal.BANNER_BOTTOM| Appodeal.INTERSTITIAL| Appodeal.VIDEO);




	}


	// Use this for initialization
	void Start () {





		//PlayGamesPlatform.Activate();
		
		Social.localUser.Authenticate((bool success) => {
			
			
		});


		//if (NoAds.ads == 0) 
		//{
			
			//Appodeal.show(Appodeal.BANNER_BOTTOM);
		//}




			
		
		



		t = 0;
		b = 1;
		v = false;
		v1 = false;
		v2 = false;
		sfx = true;
		ad = true;



	}
	
	// Update is called once per frame
	void Update () {

		//if (NoAds.ads == 0) 
		//{
			//if(ad)
			//{
		      // if(Appodeal.isLoaded(Appodeal.INTERSTITIAL))
				//{
				//	ad = false;
			    //    Appodeal.showWithPriceFloor (Appodeal.INTERSTITIAL);
				//}
			//}
		//}




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

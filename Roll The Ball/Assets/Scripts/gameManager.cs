using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;





public class gameManager : MonoBehaviour {

	public GameObject[] parts;
	private float timer, timer2, timer3;
	private int i, i2, musicOn, sfxON, startAd, showVid;
	private float targetZ;
	private float newZ;
	private Vector3 newPosition;
	private Vector3 cameraPosition, newScale;
	public Transform sky;
	private Vector3 skyPosition;
	private float speed;
	public static int record;
	private GameObject gameOverCanv,  CoinSFX2, Music2, mainCanv2, mainCanv;
	public static int dist;
	public static int coins;
	public static Vector3 cameraPos;
	public static bool isDestroy;
	public  GameObject[] balls;
	public static int iBall;
	public GameObject tiltControll, startPlane, shop, leaders, achievements, NoAds,   distanceText, coinsText, RollTheBallText,  TapToPlay, CoinSFX, Music, musicToggle, sfxToggle, ExitButton,  RecordText, coinsText2, earnCoinBut, PrizesBut, RateBut;
	public static bool game, game2, coinSound;
	private bool  buttonDown, earnMoneyOn, tapPlayOn, ad, rand, done, exitOn;
	private AudioSource SFX;
	private Toggle musicTog, sfxTog;
	private Text coinsTex, recordTex;



	public void Rate()
	{
		Application.OpenURL ("https://play.google.com/store/apps/details?id=com.CoolGamez.Ball");
	}





	public void Prizes()
	{
		Application.OpenURL ("https://www.facebook.com/CoolGamez-1531841643806935/");
	}






	public void EarnCoin()
	{
		 
		    AppnextVideoAndroid.cacheInterstitial("393dd20c-afc1-4c71-9620-8b900d89befc", AppnextVideoAndroid.REWARDED);
			coins += 10;
			PlayerPrefs.SetInt("coins", coins);
		    AppnextVideoAndroid.showInterstitial("393dd20c-afc1-4c71-9620-8b900d89befc",AppnextVideoAndroid.REWARDED);


		game2 = false;

	}






	public void ToggleSFX()
	{
		game2 = false;
		if (sfxTog.isOn) 
		{
			sfxON = 0;
			coinSound = false;
			PlayerPrefs.SetInt ("sfxON", 0);
		} else 
		{
			sfxON = 1;
			PlayerPrefs.SetInt ("sfxON", 1);
		}

	}


	public void ToggleMusic()
	{
		game2 = false;
		if (musicTog.isOn) 
		{
			musicOn = 0;
			PlayerPrefs.SetInt ("music", 0);
		} else 
		{
			musicOn = 1;
			PlayerPrefs.SetInt ("music", 1);
		}
	}













	
	
	public void Achievements()
	{

		if(Social.localUser.authenticated)
		Social.ShowAchievementsUI ();
		game2 = false;
	}



	//public void Leaders()
	//{
		//if(Social.localUser.authenticated)
		//PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIwfPExPwLEAIQAA");
		//game2 = false;
	//}



	public void Shop()
	{

		Application.LoadLevel ("Shop");


	}


	public void Exit()
	{
		exitOn = true;
		if (NoADS.ads == 0) 
		{


			AppnextVideoAndroid.showInterstitial("feb28299-00d1-4c17-a5f5-79f33cfda3bb", AppnextVideoAndroid.INTERSTITIAL);


		}

	}

	public void Retry()
	{
		Application.LoadLevel ("main");
	}




	void Awake()
	{
		string appKey = "08a8fa8c4e0bb8426794ec966da424d22321b496b5410b98";
		Appodeal.initialize(appKey, Appodeal.VIDEO| Appodeal.INTERSTITIAL|  Appodeal.BANNER_TOP| Appodeal.REWARDED_VIDEO);



	}

	// Use this for initialization
	void Start () {
		//PlayGamesPlatform.Activate ();

		Social.localUser.Authenticate((bool success) => {
			// handle success or failure
		});


		
		iBall = PlayerPrefs.GetInt ("Ball");
		Instantiate (startPlane, startPlane.transform.position, startPlane.transform.rotation);
		record = PlayerPrefs.GetInt ("record");

		coins = PlayerPrefs.GetInt ("coins");

		speed = 0.02f;
		targetZ = 20;

		isDestroy = true;




		newPosition.Set (0,0,targetZ);
		
		i = Random.Range (0, 47);
		Instantiate (parts[i], newPosition, parts[i].transform.rotation);
		
		i2 = Random.Range (0,3);
		if(i2 == 1)
		{
			i = Random.Range (0, 47);
			Instantiate (parts[i], newPosition, parts[i].transform.rotation);
		}


		targetZ += 20;

		newPosition.Set (0,0,targetZ);

		i = Random.Range (0, 47);
		Instantiate (parts[i], newPosition, parts[i].transform.rotation);
		
		i2 = Random.Range (0,3);
		if(i2 == 1)
		{
			i = Random.Range (0, 47);
			Instantiate (parts[i], newPosition, parts[i].transform.rotation);
		}

		gameOverCanv = GameObject.FindGameObjectWithTag ("gameOver");
		gameOverCanv.SetActive (false);
		mainCanv = GameObject.FindGameObjectWithTag ("mainCanvas");



		game = false;
		game2 = true;
		cameraPos = transform.position;
		earnMoneyOn = false;
		coinSound = false;
		tapPlayOn = true;
		ad = false;
		rand = true;
		exitOn = false;



		Music2 = GameObject.FindGameObjectWithTag ("music");

		musicOn = PlayerPrefs.GetInt ("music");
		sfxON = PlayerPrefs.GetInt ("sfxON");

		musicTog = musicToggle.GetComponent<Toggle> ();
		sfxTog = sfxToggle.GetComponent<Toggle> ();

		if (musicOn == 0) {
			musicTog.isOn = true;
			if (!Music2) {
				Instantiate (Music, Music.transform.position, Music.transform.rotation);
				Music2 = GameObject.FindGameObjectWithTag ("music");
			}
		} else 
			musicTog.isOn = false;



		if (sfxON == 0) 
			sfxTog.isOn = true;
		else 
			sfxTog.isOn = false;

		DontDestroyOnLoad (Music2);

		if(NoADS.ads == 0)
		   Appodeal.show (Appodeal.BANNER_TOP);
		startAd = PlayerPrefs.GetInt("startAD");
		done = true;

		coinsTex = coinsText2.GetComponent<Text> ();


		recordTex = RecordText.GetComponent<Text> ();
		recordTex.text = "Your record: " + record;
		coinsText.SetActive (false);
		distanceText.SetActive (false);


	}
	





	// Update is called once per frame
	void Update () 
	{
		coinsTex.text = "Coins: " + coins;



		if (NoADS.ads == 0) {
			if (startAd == 0) {
			
			
			
				if (ad) {
					timer3 += Time.deltaTime;
					if (timer3 >= 1) {


						if (rand) {
							showVid = Random.Range (0, 3);
							rand = false;

					
						}
				
				
						if (showVid == 1) {
					
							if (Appodeal.isLoaded (Appodeal.VIDEO)) {
								timer3 = 0;
								startAd = 5;
								PlayerPrefs.SetInt ("startAD", startAd);
						
								Appodeal.show(Appodeal.VIDEO);
								ad = false;
							}
					
						} else {
							 
								timer3 = 0;
								ad = false;
								startAd = 5;
								PlayerPrefs.SetInt ("startAD", startAd);
								AppnextVideoAndroid.showInterstitial("feb28299-00d1-4c17-a5f5-79f33cfda3bb", AppnextVideoAndroid.INTERSTITIAL);

					
						}
					}
				
				}
			}
		}


		if (musicOn == 1) 
		{    
			if (Music2)
			{
				Destroy (Music2);
			}
		} 
		else 
		{
			if(!Music2)
			{
				Instantiate (Music, Music.transform.position, Music.transform.rotation);
				Music2 = GameObject.FindGameObjectWithTag ("music");
				DontDestroyOnLoad (Music2);
			}
			     
		}


		if (sfxON == 0) 
		{
			if (coinSound) 
			{
				coinSound = false;
				Instantiate (CoinSFX, CoinSFX.transform.position, CoinSFX.transform.rotation);
				CoinSFX2 = GameObject.FindGameObjectWithTag ("SFX");
				SFX = CoinSFX2.GetComponent <AudioSource> ();

			}
		}

		if (SFX)
		{
			if (!SFX.isPlaying)
				Destroy (CoinSFX2);
		}

		if (Input.GetMouseButtonDown (0)) 
		{
			timer = 0;
			if(!earnMoneyOn)
			   game2 = true;
			buttonDown = true;

		}



		if (buttonDown) 
		{

		  if(!game)
		   {
			  
			  timer += Time.deltaTime;
			  if(timer >= 0.5f)
			     {
				   buttonDown = false;
				   timer = 0;

					if(exitOn)
						Application.Quit();
				
				     if(game2)
				         {
						   RateBut.SetActive(false);
						   PrizesBut.SetActive(false);
						   earnCoinBut.SetActive(false);
						   distanceText.SetActive (true);
						   coinsText.SetActive(true);
						   RecordText.SetActive(false);
						   coinsText2.SetActive(false);
				           Appodeal.hide(Appodeal.BANNER_TOP);
						   ExitButton.SetActive(false);
						   sfxToggle.SetActive(false);
						   musicToggle.SetActive(false);
						   TapToPlay.SetActive(false);
					       shop.SetActive(false);
					       leaders.SetActive (false);
					       achievements.SetActive(false);
					       NoAds.SetActive(false);
					       Instantiate (balls [iBall], new Vector3 (0, 1, 0), balls [iBall].transform.rotation);
					       Instantiate (tiltControll, tiltControll.transform.position, tiltControll.transform.rotation);
					       balls [iBall] = GameObject.FindGameObjectWithTag ("Ball");
					       game = true;
				         }
				
			      }
		   }
		}
		
		
		
		
		
		if(game)
		{
			cameraPos = transform.position;


			
			if(exitOn)
			{
				timer += Time.deltaTime;
				if(timer >= 0.5f)
				   Application.Quit();
			}

			
			if (isDestroy) {
				isDestroy = false;

				targetZ += 20;
				newPosition.Set (0, 0, targetZ);

				i = Random.Range (0, 47);
				Instantiate (parts [i], newPosition, parts [i].transform.rotation);

				i2 = Random.Range (0, 3);
				if (i2 == 1) {
					i = Random.Range (0, 47);
					Instantiate (parts [i], newPosition, parts [i].transform.rotation);
				}


			}

			if (balls [iBall]) 
			{
				if (balls [iBall].transform.position.y <= -20) 
				{
					if(NoADS.ads == 0)
					   Appodeal.show(Appodeal.BANNER_TOP);
					ad = true;
					if (done)
					{
						done = false;
					    if (startAd > 0)
					         startAd -= 1;
					}
					PlayerPrefs.SetInt("startAD", startAd);
					gameOverCanv.SetActive (true);
					mainCanv.SetActive (false);
					PlayerPrefs.SetInt ("coins", coins);

				}



			}




				
			newZ = transform.position.z;
			 
				
				cameraPosition.Set (0, 35, newZ + speed);
				skyPosition.Set (0, -10, newZ + speed);
				sky.position = skyPosition;
				transform.position = cameraPosition;
				if (speed < 0.037f)
					speed += 0.000007f;

	    




		}


	
	if (tapPlayOn) 
		{
			if (!game) 
			{
		
		
				timer2 += Time.deltaTime;
				if (timer2 >= 1) 
				{
					timer2 = 0;

					if (TapToPlay.activeSelf)
						TapToPlay.SetActive (false);
					else
						TapToPlay.SetActive (true);
				}
		
			}
		}
		 

	
	}
}


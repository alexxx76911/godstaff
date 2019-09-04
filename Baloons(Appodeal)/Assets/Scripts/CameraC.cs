using UnityEngine;
using System.Collections;
//using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class CameraC : MonoBehaviour{

	private Vector3 newPosition;
	public GameObject redbaloon;
	public GameObject pinkbaloon;
	public GameObject bluebaloon;
	public GameObject yellowbaloon;
	public GameObject lightbluebaloon;
	public GameObject greenbaloon;
	public GameObject purplebaloon;
	public GameObject orangebaloon;
	public GameObject bonusbal;
	public GameObject badbal;
	public GameObject superbal;
	public GameObject superbal2;
	public GameObject bomba;
	public static GameObject boomBaloon;
	public static GameObject boomBomb;
	public GameObject pause;
	public GameObject snow;
	public GameObject playBaloon;
	public GameObject exitBaloon;
	private GameObject canvas, canvas2;
	private int p;
	private Ray ray;
	private RaycastHit hit;
	private GameObject[] arr = new GameObject[8];
	public GameObject[] backGrounds;
	public float x, y, width, height;
	Vector2 m = new Vector2(20f, 4f);
	public static float speed, speed1;
	private float t;
	private float n, n1;
	private float t1;
	private int b;
	private float t2, t3, t4, t5, t6, t7, t8;
	private float b1, b2, b3;
	private float b4, b5, b6, b7;
	public static Vector2 s, s1, s2;
	public static int i1, baloons, loses;
	public  GameObject explosion;
	public static int record;
	public static Vector3 m1;
	public static bool h, h1, h2, h3, h4, h5, h6, h7, h8, h9;
	private int i, i2;
	private int r;



	// Use this for initialization
	void Start () {



		Appodeal.hide(Appodeal.BANNER);

		record = PlayerPrefs.GetInt ("record");
		speed = 3;
		i1 = 3;
		baloons = 0;
		t = 0;
		t1 = 0;
		b = Random.Range (30, 60);
		b1 = Random.Range (10, 15);
		b2 = Random.Range (40, 70);
		b3 = Random.Range (10, 30);
		b4 = Random.Range (2, 2.5f);
		b5 = Random.Range (40, 70);
		b6 = Random.Range (30, 50);
		b7 = 3;
		t2 = 0;
		t3 = 0;
		t4 = 0;
		t5 = 0;
		t6 = 0;
		t7 = 0;
		t8 = 0;
		loses = 5;
		arr [0] = redbaloon;
		arr [1] = pinkbaloon;
		arr [2] = bluebaloon;
		arr [3] = yellowbaloon;
		arr [4] = lightbluebaloon;
		arr [5] = purplebaloon;
		arr [6] = orangebaloon;
		arr [7] = greenbaloon;
		s = new Vector2 (0,0);
		s1 = new Vector2 (0,0);
		s2 = new Vector2 (0, 0);
		h = false;
		h1 = false;
		h2 = false;
		h3 = false;
		h4 = false;
		h5 = false;
		h6 = false;
		h7 = false;
		h8 = false;
		h9 = false;
		n = 0;
		n1 = 0;

		canvas = GameObject.FindGameObjectWithTag ("Canvas");

		canvas.SetActive (false);

		i2 = Random.Range (0, 22);
		Instantiate (backGrounds [i2], new Vector3 (0, 0, 10), backGrounds [i2].transform.rotation);



	}




	// Update is called once per frame
	void Update () {
		if (baloons == 1000)
			n = 0.6f;
		if (baloons == 2000)
			n = 0.65f;

		if (record < baloons) 
		{
						record = baloons;
			PlayerPrefs.SetInt("record", record);


		}

		if (h4 == false) {
						if (Time.timeSinceLevelLoad >= t + b7) {
								t = Time.timeSinceLevelLoad;
								if (speed < 6)
										speed += 0.1f;
				         
								if (n < 0.5f)
										n += 0.02f;
								if (n1 < 10f)
										n1 += 0.2f;
						}



				



						if (Time.timeSinceLevelLoad >= t5 + b4) {

								t5 = Time.timeSinceLevelLoad;
								p = Random.Range (0, 7);
								newPosition = new Vector2 (Random.Range (-2.542639f, 2.542639f), -5.817978f);
								arr[p].transform.position = newPosition;

								Instantiate (arr [p], arr [p].transform.position, arr [p].transform.rotation);

								b4 = Random.Range (0.1f , 1 - n );

						}



		
		
						if (Time.timeSinceLevelLoad >= t1 + b) {

								t1 = Time.timeSinceLevelLoad;
								newPosition = new Vector2 (Random.Range (-2.542639f, 2.542639f), -5.817978f);
								bonusbal.transform.position = newPosition;
								Instantiate (bonusbal, bonusbal.transform.position, bonusbal.transform.rotation);
								b = Random.Range (30, 60);
						}

						if (Time.timeSinceLevelLoad >= t2 + b1) {
			
								t2 = Time.timeSinceLevelLoad;
								newPosition = new Vector3 (Random.Range (-2.542639f, 2.542639f), -5.817978f, 2);
								badbal.transform.position = newPosition;

								Instantiate (badbal, badbal.transform.position, badbal.transform.rotation);

								b1 = Random.Range (0.1f , 1 - n);
						} 
	    
						if (Time.timeSinceLevelLoad >= t3 + b2) {
								t3 = Time.timeSinceLevelLoad;
								newPosition = new Vector2 (Random.Range (-2.542639f, 2.542639f), -5.817978f);
								bomba.transform.position = newPosition;
								Instantiate (bomba, bomba.transform.position, bomba.transform.rotation);
								b2 = Random.Range (40, 70);
						}

						if (Time.timeSinceLevelLoad >= t4 + b3) {
								t4 = Time.timeSinceLevelLoad;
								newPosition = new Vector2 (Random.Range (-2.199114f, 2.199114f), -5.817978f);
								superbal.transform.position = newPosition;
								Instantiate (superbal, superbal.transform.position, superbal.transform.rotation);
								b3 = Random.Range (10, 30);
						}

			if (Time.timeSinceLevelLoad >= t8 + b6) {
				t8 = Time.timeSinceLevelLoad;
				newPosition = new Vector2 (Random.Range (-2.199114f, 2.199114f), -5.817978f);
				superbal2.transform.position = newPosition;
				Instantiate (superbal2, superbal2.transform.position, superbal2.transform.rotation);
				b6 = Random.Range (30, 50);
			}




						if (Time.timeSinceLevelLoad >= t7 + b5){
				t7 = Time.timeSinceLevelLoad;
				newPosition = new Vector2 (Random.Range (-2.199114f, 2.199114f), -5.817978f);
				snow.transform.position = newPosition;
				Instantiate (snow, snow.transform.position, snow.transform.rotation);
				b5 = Random.Range (40, 70);
			}






			         if (loses < 0)
			             {
				              if (Social.localUser.authenticated)
				           {
					          Social.ReportScore (baloons, "CgkIhYz47rgREAIQAQ", (bool success) => {

			                    });
					          
					          if (baloons >= 500)
						Social.ReportProgress("CgkIhYz47rgREAIQAg", 100.0f, (bool success) => {

						          });

					          if (baloons >= 1000)
						Social.ReportProgress("CgkIhYz47rgREAIQAw", 100.0f, (bool success) => {
							
						          });

					          if (baloons >= 2000)
						Social.ReportProgress("CgkIhYz47rgREAIQBA", 100.0f, (bool success) => {
							
						          });

					          if (baloons >= 3000)
						Social.ReportProgress("CgkIhYz47rgREAIQBQ", 100.0f, (bool success) => {
							
						          });

					          if (baloons >= 5000)
						Social.ReportProgress("CgkIhYz47rgREAIQBg", 100.0f, (bool success) => {
							
						          });

					          if (baloons >= 8000)
						Social.ReportProgress("CgkIhYz47rgREAIQBw", 100.0f, (bool success) => {
							
						          });
				                
				           }
				              
				                 
					                
				                
					              
					     
				                
				                canvas.SetActive(true);
				                
								Application.LoadLevel ("Game Over");
			             }
				}

						
		                        if (Input.GetMouseButtonDown (0)) {
								ray = Camera.main.ScreenPointToRay (Input.mousePosition);
								if (Physics.Raycast (ray, out hit, 100)) {
				
										if (hit.transform.position.z == 2.5) {
					                        if (h4 == false){
					                                   h4 = true;
					                                   h5 = true;
						                               h9 = true;
					                                   playBaloon.transform.position = new Vector3 (-1.19869f, -0.9119208f, -1);
					                                   exitBaloon.transform.position = new Vector3 (1.258378f, -0.9119208f, -1);
													   pause.transform.position = new Vector2 (0.5f, 0.7f);
													   Instantiate (pause, pause.transform.position, pause.transform.rotation);
					                                   Instantiate (playBaloon, playBaloon.transform.position, playBaloon.transform.rotation);
					                                   Instantiate (exitBaloon, exitBaloon.transform.position, exitBaloon.transform.rotation);
												    } 
				                              }
			                                      
					                            if (h4 == true){
					                            if (hit.transform.position.z == -1){ 
												Instantiate (explosion, hit.transform.position, hit.transform.rotation);
												m1 = hit.transform.position;
												m1.z -= 2; 
												hit.transform.position = m;
					                                  }
					                            }
				                            
					if (h9 == false){
					Instantiate (explosion, hit.transform.position, hit.transform.rotation);
					m1 = hit.transform.position;
					m1.z -= 2; 
					hit.transform.position = m;

				}
										
			}
								
		}
						

				


		if (h5 == true) { 
			h5 = false;
			speed1 = speed;
			speed = 0;
			t6 = Time.timeSinceLevelLoad;

		}
		
		






		if (h6 == true) {
				
						if (Time.timeSinceLevelLoad >= t6 + 3){ 
				speed = speed1;
				                h4 = false;
				h6 = false;
			}
			            
		}		 
				

		if (h7 == true) { 
			h7 = false;
			t = Time.timeSinceLevelLoad;
		}

		if (h8 == true) {
			if (Time.timeSinceLevelLoad >= t + 1)
				Application.Quit ();
		}


	}




	void LateUpdate(){




		if (i1 == 2){
			s = new Vector2 (0, 0);

		}
		
		i1++;
		if (i1 > 3)
						i1 = 3;
	}

}




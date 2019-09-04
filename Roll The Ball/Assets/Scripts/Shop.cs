using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Shop : MonoBehaviour {

	public GameObject[] balls, buttons;
	private Text text1, textCoin;
	private Rigidbody rig;
	private GameObject ball;
	private int iBall, coins;
	private Quaternion newRotation;
	private int isPurchased, isPurchased2, isPurchased3, isPurchased4, isPurchased5, isPurchased6, isPurchased7, isPurchased8, isPurchased9, isPurchased10, isPurchased11, isPurchased12, isPurchased13;
	public GameObject CoinsText;

	void Start()
	{

		isPurchased = PlayerPrefs.GetInt ("isPurch");
		if (isPurchased == 1)
		{
			text1 = buttons [0].GetComponentInChildren<Text> ();
			text1.text = "Ball 2";

		}
		isPurchased2 = PlayerPrefs.GetInt ("isPurch2");
		if (isPurchased2 == 1)
		{
			text1 = buttons [1].GetComponentInChildren<Text> ();
			text1.text = "Ball 3";
			
		}
		isPurchased3 = PlayerPrefs.GetInt ("isPurch3");
		if (isPurchased3 == 1)
		{
			text1 = buttons [2].GetComponentInChildren<Text> ();
			text1.text = "Ball 4";
			
		}
		isPurchased4 = PlayerPrefs.GetInt ("isPurch4");
		if (isPurchased4 == 1)
		{
			text1 = buttons [3].GetComponentInChildren<Text> ();
			text1.text = "Ball 5";
			
		}
		isPurchased5 = PlayerPrefs.GetInt ("isPurch5");
		if (isPurchased5 == 1)
		{
			text1 = buttons [4].GetComponentInChildren<Text> ();
			text1.text = "Ball 6";
			
		}
		isPurchased6 = PlayerPrefs.GetInt ("isPurch6");
		if (isPurchased6 == 1)
		{
			text1 = buttons [5].GetComponentInChildren<Text> ();
			text1.text = "Ball 7";
			
		}
		isPurchased7 = PlayerPrefs.GetInt ("isPurch7");
		if (isPurchased7 == 1)
		{
			text1 = buttons [6].GetComponentInChildren<Text> ();
			text1.text = "Ball 8";
			
		}
		isPurchased8 = PlayerPrefs.GetInt ("isPurch8");
		if (isPurchased8 == 1)
		{
			text1 = buttons [7].GetComponentInChildren<Text> ();
			text1.text = "Ball 9";
			
		}
		isPurchased9 = PlayerPrefs.GetInt ("isPurch9");
		if (isPurchased9 == 1)
		{
			text1 = buttons [8].GetComponentInChildren<Text> ();
			text1.text = "Ball 10";
			
		}
		isPurchased10 = PlayerPrefs.GetInt ("isPurch10");
		if (isPurchased10 == 1)
		{
			text1 = buttons [9].GetComponentInChildren<Text> ();
			text1.text = "Ball 11";
			
		}
		isPurchased11 = PlayerPrefs.GetInt ("isPurch11");
		if (isPurchased11 == 1)
		{
			text1 = buttons [10].GetComponentInChildren<Text> ();
			text1.text = "Ball 12";
			
		}
		isPurchased12 = PlayerPrefs.GetInt ("isPurch12");
		if (isPurchased12 == 1)
		{
			text1 = buttons [11].GetComponentInChildren<Text> ();
			text1.text = "Ball 13";
			
		}
		isPurchased13 = PlayerPrefs.GetInt ("isPurch13");
		if (isPurchased13 == 1)
		{
			text1 = buttons [12].GetComponentInChildren<Text> ();
			text1.text = "Ball 14";
			
		}


		coins = PlayerPrefs.GetInt ("coins");


		newRotation = Quaternion.Euler(0, 1, 0); 
		iBall = PlayerPrefs.GetInt ("Ball");
		rig = balls [iBall].GetComponent <Rigidbody> ();
		rig.useGravity = false;
		balls [iBall].transform.localScale = new Vector3 (3, 3, 3);
		Instantiate(balls[iBall], new Vector3(0,0,0), balls [iBall].transform.rotation);
		rig.useGravity = true;
		balls [iBall].transform.localScale = new Vector3 (1, 1, 1);
		ball = GameObject.FindGameObjectWithTag ("Ball");
		textCoin = CoinsText.GetComponent <Text> ();


	}




	void Update()
	{
		textCoin.text = "Coins: " + coins;

		if (ball)
			ball.transform.rotation = ball.transform.rotation * newRotation;
		else ball = GameObject.FindGameObjectWithTag ("Ball");

	}

	public void Back()
	{

		Application.LoadLevel ("main");
	}


	public void Blue()
	{
		if (isPurchased == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [0].GetComponentInChildren<Text> ();
				text1.text = "Ball 2";
				isPurchased = 1;
				PlayerPrefs.SetInt ("isPurch", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [1].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [1].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [1], new Vector3 (0, 0, 0), balls [1].transform.rotation);
				rig.useGravity = true;
				balls [1].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 1;
				PlayerPrefs.SetInt ("Ball", 1);
			}

		} 

		else 
		{

			Destroy (ball);
			rig = balls [1].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [1].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [1], new Vector3 (0, 0, 0), balls [1].transform.rotation);
			rig.useGravity = true;
			balls [1].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 1;
			PlayerPrefs.SetInt ("Ball", 1);
		}

	}

	public void BlueGreen()
	{


		if (isPurchased2 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [1].GetComponentInChildren<Text> ();
				text1.text = "Ball 3";
				isPurchased2 = 1;
				PlayerPrefs.SetInt ("isPurch2", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [2].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [2].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [2], new Vector3 (0, 0, 0), balls [2].transform.rotation);
				rig.useGravity = true;
				balls [2].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 2;
				PlayerPrefs.SetInt ("Ball", 2);


			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [2].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [2].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [2], new Vector3 (0, 0, 0), balls [2].transform.rotation);
			rig.useGravity = true;
			balls [2].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 2;
			PlayerPrefs.SetInt ("Ball", 2);
		}

	}




	public void Brown()
	{


		if (isPurchased3 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [2].GetComponentInChildren<Text> ();
				text1.text = "Ball 4";
				isPurchased3 = 1;
				PlayerPrefs.SetInt ("isPurch3", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [3].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [3].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [3], new Vector3 (0, 0, 0), balls [3].transform.rotation);
				rig.useGravity = true;
				balls [3].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 3;
				PlayerPrefs.SetInt ("Ball", 3);
				
				
			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [3].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [3].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [3], new Vector3 (0, 0, 0), balls [3].transform.rotation);
			rig.useGravity = true;
			balls [3].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 3;
			PlayerPrefs.SetInt ("Ball", 3);
		}

	}



	public void Green()
	{

		if (isPurchased4 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [3].GetComponentInChildren<Text> ();
				text1.text = "Ball 5";
				isPurchased4 = 1;
				PlayerPrefs.SetInt ("isPurch4", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [4].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [4].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [4], new Vector3 (0, 0, 0), balls [4].transform.rotation);
				rig.useGravity = true;
				balls [4].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 4;
				PlayerPrefs.SetInt ("Ball", 4);
				
			}
		} 

		else 
		{

			Destroy (ball);
			rig = balls [4].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [4].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [4], new Vector3 (0, 0, 0), balls [4].transform.rotation);
			rig.useGravity = true;
			balls [4].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 4;
			PlayerPrefs.SetInt ("Ball", 4);
		}

	}



	public void LightBlue()
	{

		if (isPurchased5 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [4].GetComponentInChildren<Text> ();
				text1.text = "Ball 6";
				isPurchased5 = 1;
				PlayerPrefs.SetInt ("isPurch5", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [5].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [5].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [5], new Vector3 (0, 0, 0), balls [5].transform.rotation);
				rig.useGravity = true;
				balls [5].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 5;
				PlayerPrefs.SetInt ("Ball", 5);


				
			}
		} 

		else 
		{

			Destroy (ball);
			rig = balls [5].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [5].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [5], new Vector3 (0, 0, 0), balls [5].transform.rotation);
			rig.useGravity = true;
			balls [5].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 5;
			PlayerPrefs.SetInt ("Ball", 5);
		}

	}




	public void LightGreen()
	{

		if (isPurchased6 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [5].GetComponentInChildren<Text> ();
				text1.text = "Ball 7";
				isPurchased6 = 1;
				PlayerPrefs.SetInt ("isPurch6", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [6].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [6].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [6], new Vector3 (0, 0, 0), balls [6].transform.rotation);
				rig.useGravity = true;
				balls [6].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 6;
				PlayerPrefs.SetInt ("Ball", 6);
				
				
				
			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [6].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [6].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [6], new Vector3 (0, 0, 0), balls [6].transform.rotation);
			rig.useGravity = true;
			balls [6].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 6;
			PlayerPrefs.SetInt ("Ball", 6);
		}

	}



	public void Orange()
	{

		if (isPurchased7 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [6].GetComponentInChildren<Text> ();
				text1.text = "Ball 8";
				isPurchased7 = 1;
				PlayerPrefs.SetInt ("isPurch7", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [7].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [7].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [7], new Vector3 (0, 0, 0), balls [7].transform.rotation);
				rig.useGravity = true;
				balls [7].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 7;
				PlayerPrefs.SetInt ("Ball", 7);
				
				
				
			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [7].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [7].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [7], new Vector3 (0, 0, 0), balls [7].transform.rotation);
			rig.useGravity = true;
			balls [7].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 7;
			PlayerPrefs.SetInt ("Ball", 7);
		}

	}



	public void Pink()
	{

		if (isPurchased8 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [7].GetComponentInChildren<Text> ();
				text1.text = "Ball 9";
				isPurchased8 = 1;
				PlayerPrefs.SetInt ("isPurch8", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [8].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [8].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [8], new Vector3 (0, 0, 0), balls [8].transform.rotation);
				rig.useGravity = true;
				balls [8].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 8;
				PlayerPrefs.SetInt ("Ball", 8);
				
				
				
			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [8].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [8].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [8], new Vector3 (0, 0, 0), balls [8].transform.rotation);
			rig.useGravity = true;
			balls [8].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 8;
			PlayerPrefs.SetInt ("Ball", 8);
		}

	}



	public void Purple()
	{

		if (isPurchased9 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [8].GetComponentInChildren<Text> ();
				text1.text = "Ball 10";
				isPurchased9 = 1;
				PlayerPrefs.SetInt ("isPurch9", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [9].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [9].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [9], new Vector3 (0, 0, 0), balls [9].transform.rotation);
				rig.useGravity = true;
				balls [9].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 9;
				PlayerPrefs.SetInt ("Ball", 9);
				
				
				
			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [9].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [9].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [9], new Vector3 (0, 0, 0), balls [9].transform.rotation);
			rig.useGravity = true;
			balls [9].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 9;
			PlayerPrefs.SetInt ("Ball", 9);
		}

	}



	public void Red()
	{

		if (isPurchased10 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [9].GetComponentInChildren<Text> ();
				text1.text = "Ball 11";
				isPurchased10 = 1;
				PlayerPrefs.SetInt ("isPurch10", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [10].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [10].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [10], new Vector3 (0, 0, 0), balls [10].transform.rotation);
				rig.useGravity = true;
				balls [10].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 10;
				PlayerPrefs.SetInt ("Ball", 10);
				
				
				
			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [10].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [10].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [10], new Vector3 (0, 0, 0), balls [10].transform.rotation);
			rig.useGravity = true;
			balls [10].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 10;
			PlayerPrefs.SetInt ("Ball", 10);
		}

	}



	public void RedBlue()
	{

		if (isPurchased11 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [10].GetComponentInChildren<Text> ();
				text1.text = "Ball 12";
				isPurchased11 = 1;
				PlayerPrefs.SetInt ("isPurch11", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [11].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [11].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [11], new Vector3 (0, 0, 0), balls [11].transform.rotation);
				rig.useGravity = true;
				balls [11].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 11;
				PlayerPrefs.SetInt ("Ball", 11);
				
				
				
			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [11].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [11].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [11], new Vector3 (0, 0, 0), balls [11].transform.rotation);
			rig.useGravity = true;
			balls [11].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 11;
			PlayerPrefs.SetInt ("Ball", 11);
		}

	}




	public void RedGreen()
	{

		if (isPurchased12 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [11].GetComponentInChildren<Text> ();
				text1.text = "Ball 13";
				isPurchased12 = 1;
				PlayerPrefs.SetInt ("isPurch12", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [12].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [12].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [12], new Vector3 (0, 0, 0), balls [12].transform.rotation);
				rig.useGravity = true;
				balls [12].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 12;
				PlayerPrefs.SetInt ("Ball", 12);
				
				
				
			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [12].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [12].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [12], new Vector3 (0, 0, 0), balls [12].transform.rotation);
			rig.useGravity = true;
			balls [12].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 12;
			PlayerPrefs.SetInt ("Ball", 12);
		}

	}



	public void Yellow()
	{

		if (isPurchased13 == 0) 
		{
			if (coins >= 150) 
			{
				text1 = buttons [12].GetComponentInChildren<Text> ();
				text1.text = "Ball 14";
				isPurchased13 = 1;
				PlayerPrefs.SetInt ("isPurch13", 1);
				coins -= 150;
				PlayerPrefs.SetInt ("coins", coins);
				Destroy (ball);
				rig = balls [13].GetComponent <Rigidbody> ();
				rig.useGravity = false;
				balls [13].transform.localScale = new Vector3 (3, 3, 3);
				Instantiate (balls [13], new Vector3 (0, 0, 0), balls [13].transform.rotation);
				rig.useGravity = true;
				balls [13].transform.localScale = new Vector3 (1, 1, 1);
				gameManager.iBall = 13;
				PlayerPrefs.SetInt ("Ball", 13);
				
				
				
			}
		} 

		else 
		{
			Destroy (ball);
			rig = balls [13].GetComponent <Rigidbody> ();
			rig.useGravity = false;
			balls [13].transform.localScale = new Vector3 (3, 3, 3);
			Instantiate (balls [13], new Vector3 (0, 0, 0), balls [13].transform.rotation);
			rig.useGravity = true;
			balls [13].transform.localScale = new Vector3 (1, 1, 1);
			gameManager.iBall = 13;
			PlayerPrefs.SetInt ("Ball", 13);
		}

	}



	public void Gray()
	{

		Destroy (ball);
		rig = balls [0].GetComponent <Rigidbody> ();
		rig.useGravity = false;
		balls [0].transform.localScale = new Vector3 (3, 3, 3);
		Instantiate (balls [0], new Vector3(0,0,0), balls [0].transform.rotation);
		rig.useGravity = true;
		balls [0].transform.localScale = new Vector3 (1, 1, 1);
		gameManager.iBall = 0;
		PlayerPrefs.SetInt ("Ball", 0);

	}















}

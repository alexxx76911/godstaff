using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class canvas : MonoBehaviour {

	public GameObject Title;
	private Text dis;
	private GameObject ball;
	private int dist;
	private bool done;


	// Use this for initialization
	void Start () {



		done = false;
	}
	
	// Update is called once per frame
	void Update () {


		
		if (gameManager.game) 
		{
			if(!done)
			{
		    done = true;
			dis = GetComponentInChildren<Text> ();
			Title.SetActive(false);
			ball = GameObject.FindGameObjectWithTag ("Ball");
			}

			if(ball)
				dist = (int)ball.transform.position.z;
			dis.text = "Distance: " + dist;
		}


	
	}
}

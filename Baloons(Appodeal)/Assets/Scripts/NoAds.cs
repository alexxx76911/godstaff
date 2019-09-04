using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using OnePF;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

/*public class NoAds : MonoBehaviour {
	private float speed;
	private float t;
	private float b;
	private float timer;
	private Vector3 oldPosition;
	private bool isBoom;
	public GameObject boomBaloon;
	public static int ads;

	public const string SKU = "no_ads3";
	public const string googleKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA0keJlzQOmDn29dU5GwkpFt9vajHE2x/wrmOFxhWJWdyNV2q908XdVxVPKnb+02vtMAKKaxYjoSTPXs1R0/9v+0gNS8aID648apSffYq+606YBkv8HZmZfK/M6gEf7CxWchxxfxap/9kawBjCR7LxW1Zsx7PRoppdJaYbGaz764iqx0elSni0i0oKbThhEdjhfaoCGLtDi20Uvr2Og64+4wYjL1t/K/d44TUEd6eXTq7QCI8tg1ZM8rzIZSN4XxYitPUgG8rOVRbup4jk67y/fxooTqmHFlsXZI6jYG4SqXB7vMDdW6fa8jc3ZWNnhveyGLlsDVXSjvFwM6nL66O71wIDAQAB";
    
	private void Awake()
	    {
		ads = PlayerPrefs.GetInt ("ads");
		OpenIABEventManager.purchaseSucceededEvent += OnPurchaseSucceeded;

		}

	private void OnDestroy()
	    {
		OpenIABEventManager.purchaseSucceededEvent -= OnPurchaseSucceeded;
		}



	// Use this for initialization
	void Start () {

		speed = 0.5f;
		t = 0;
		b = 0.4f;
		timer = 0;
		oldPosition = transform.position; 
		isBoom = false;

		OpenIAB.mapSku (SKU, OpenIAB_Android.STORE_GOOGLE, "no_ads3");
		var options = new OnePF.Options ();
		options.storeKeys.Add (OpenIAB_Android.STORE_GOOGLE, googleKey);
		OpenIAB.init (options);
	
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
				OpenIAB.purchaseProduct(SKU);
				transform.position = oldPosition;
				isBoom = false;
				
			}
			
			
			
			
		}

	}

	private void OnPurchaseSucceeded(Purchase purchase)
	{
		if (purchase.Sku == SKU) 
		          {
						ads = 1;
			            PlayerPrefs.SetInt("ads", ads);
			            Appodeal.hide(Appodeal.BANNER);
		          }


	
    }
}*/

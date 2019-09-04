using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using OnePF;

public class NoADS : MonoBehaviour {

	public static int ads;
	
	public const string SKU = "no_ads";
	public const string googleKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAmRPrDHN6qNKC2KUwz0YiwKofQ+FIAhXkw95pcFtdskpcQ9nx+yaC1Aa4VRsx+6Cosy93I5WeooLEuJjF8aQJ7tx3yZsFhPfQXTOxtvkI/yneE2bvxf+CxL8+iNkGZmEctFbaYMsixTHlz8W530LQPRrWhapFf8MxcCdLLzo9wf0Yxp6e2VWi7DTKlSZ0cVAHGsJXZDT+mP694GLOei+sWbEndNXqpaBcIAA3vT6flHHwqXEYLE7djKe3+uYuOeKvf7Z71FvO3YriSUskOnmnae/EFWXDTcw1KcEM99j6/B1R6gmyZgiXu9kpfP6LBpt4daCIS/C3rC5OpIekgcIICQIDAQAB";
	

	public void Purchase()
	{
		gameManager.game2 = false;
		OpenIAB.purchaseProduct(SKU);
	}

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

		OpenIAB.mapSku (SKU, OpenIAB_Android.STORE_GOOGLE, "no_ads");
		var options = new OnePF.Options ();
		options.storeKeys.Add (OpenIAB_Android.STORE_GOOGLE, googleKey);
		OpenIAB.init (options);
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}


	private void OnPurchaseSucceeded(Purchase purchase)
	{
		if (purchase.Sku == SKU) 
		{
			ads = 1;
			PlayerPrefs.SetInt("ads", ads);

		}
		
		
		
	}


}

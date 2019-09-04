using UnityEngine;
using System.Collections;

public class DestroyEff : MonoBehaviour {

	private ParticleSystem Effect;

	// Use this for initialization
	void Start () {
		Effect = GetComponent <ParticleSystem> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
      if (!Effect.IsAlive())
			Destroy (gameObject);
	}
}

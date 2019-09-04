using UnityEngine;
using System.Collections;

public class notDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	public void sfxOff()
	{   if (cameraMainMenu.sfx)
						cameraMainMenu.sfx = false;
				else
						cameraMainMenu.sfx = true;
		}
}

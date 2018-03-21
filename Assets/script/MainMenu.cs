using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void PlayGame() {
		// pindah scene
		Application.LoadLevel("scene1");
	}

	public void Settings() {
		
	}

	public void QuitGame() {
		Application.Quit();
	}
}

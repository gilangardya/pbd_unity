using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLastScene : MonoBehaviour {
	void OnTriggerEnter(Collider col) {
		if (col.CompareTag("Player")) {
			SceneManager.LoadScene("scene2");
		}
	}
}

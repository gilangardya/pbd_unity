using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour {

	public AudioMixer audioMixer;

	// Use to change value
	public void SetVolume (float volume) {
		audioMixer.SetFloat ("volume", volume);
	}
}

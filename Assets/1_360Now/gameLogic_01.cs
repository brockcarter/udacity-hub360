using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameLogic_01 : MonoBehaviour {

	//created references to all of the voiceover clips
	public AudioClip vo0101;
	public AudioClip vo0102;
	public AudioClip vo0103;

	//created references to the UI elements in the scene
	public GameObject uiSamsung;
	public GameObject uiLytro;



	// Use this for initialization
	IEnumerator Start () {
		//accesses the audio source present on the game object and names it "audio"
		AudioSource audio = GetComponent<AudioSource> ();
		//sets "audio" to contain the vo0101 audio clip and plays it
		audio.clip = vo0101;
		audio.Play ();
		//The magic! This pauses the method as long as the clip is still playing
		yield return new WaitForSeconds(audio.clip.length);
		//Once the first vo is done, activate the second UI
		uiSamsung.SetActive (true);
		//replace vo0101 wtih vo0102 in AudioSource and play
		audio.clip = vo0102;
		audio.Play();
		//again, this will pause the method
		yield return new WaitForSeconds(audio.clip.length);
		//activates last UI element and vo clip
		uiLytro.SetActive (true);
		audio.clip = vo0103;
		audio.Play();
	
	
	
	}

	//Changes the scene
	public void GoToScene02 () {

		SceneManager.LoadScene ("Apartment", LoadSceneMode.Single);
	}
}

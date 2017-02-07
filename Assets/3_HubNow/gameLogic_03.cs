using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameLogic_03 : MonoBehaviour {

	public GameObject player;
	public GameObject hubStartPosition;

	public AudioClip vo0301;
	public AudioClip vo0302;


	// Use this for initialization
	void Start () {
		iTween.MoveTo (player, hubStartPosition.transform.position, 1.5f);
		StartCoroutine (voiceOver03 ());
	}
	
	IEnumerator voiceOver03 () {
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = vo0301;
		audio.Play ();
		yield return new WaitForSeconds (audio.clip.length);

		audio.clip = vo0302;
		audio.Play ();
		yield return new WaitForSeconds(audio.clip.length);
	}







	public void onToScene04 () {
		SceneManager.LoadScene ("Garage", LoadSceneMode.Single);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {
	public GameObject player;

	public AudioSource hubAudio_02_01;
	public AudioSource hubAudio_02_02;
	public AudioSource hubAudio_02_03;
	public AudioSource hubAudio_02_04;
	public AudioSource hubAudio_02_05;
	public AudioSource hubAudio_02_06;
	public AudioSource tvPlayingAudio;

	public GameObject panelOne;
	public GameObject panelTwo;
	public GameObject panelThree;
	public GameObject panelFour;
	public GameObject panelFive;

	public GameObject firstPosition;
	public GameObject secondPosition;
	public GameObject thirdPosition;


	// Use this for initialization
	void Start () {
		player.transform.position = firstPosition.transform.position;
		panelOne.SetActive (true);
		hubAudio_02_01.PlayDelayed (1);
	}


	public void Scene02VO2 () {
		if (!hubAudio_02_01.isPlaying) {
			panelOne.SetActive (false); 
			hubAudio_02_02.Play ();
			panelTwo.SetActive (true);
		}
	}

	public void Scene02VO3 () {
		if (!hubAudio_02_02.isPlaying) {
			iTween.MoveTo (player, secondPosition.transform.position, 1.5f);
			panelTwo.SetActive (false);
			hubAudio_02_03.Play ();
			panelThree.SetActive (true);
		}
	}

	public void Scene02VO4 () {
		if (!hubAudio_02_03.isPlaying) {
			panelThree.SetActive (false);
			hubAudio_02_04.Play ();
			panelFour.SetActive (true);
			hubAudio_02_05.PlayDelayed (3);
		}
	}

	public void Scene02VO5 () {
		if (!hubAudio_02_05.isPlaying) {
			tvPlayingAudio.Play ();
			panelFour.SetActive (false);
			iTween.MoveTo (player, thirdPosition.transform.position, 1.5f);
			hubAudio_02_06.PlayDelayed (2);
			panelFive.SetActive (true);
		}
	}

	public void onToScene03 () {
		SceneManager.LoadScene ("HubNow", LoadSceneMode.Single);
	}
}

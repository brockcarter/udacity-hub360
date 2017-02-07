using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameLogic04 : MonoBehaviour {

	public GameObject player;

	//establishes the game object to be revealed last, our sponsored item
	public GameObject sponsoredUI;

	//references to other UI elements in scene
	public GameObject startUI;
	public GameObject UI1;
	public GameObject UI2;
	public GameObject endUI;

	//references to the info notes in the scene
	public GameObject info1;
	public GameObject info2;
	public GameObject info3;

	public GameObject position1;
	public GameObject position2;
	public GameObject position3;

	public AudioClip vo0401;
	public AudioClip vo0402;
	public AudioClip vo0403;
	public AudioClip vo0404;
	public AudioClip vo0405;
	public AudioClip vo0406;
	public AudioClip vo0407;
	public AudioClip vo0408;
	public AudioClip vo0409;

	IEnumerator Start () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		player.transform.position = position1.transform.position;
		yield return new WaitForSeconds(audio.clip.length);
		audio.clip = vo0402;
		audio.Play();
	}

	public void enterRoom(){
		startUI.SetActive (false);
		iTween.MoveTo (player, position2.transform.position, 1.5f);
		StartCoroutine (RoomVO ());
	}

	IEnumerator RoomVO (){
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = vo0403;
		audio.Play ();
		yield return new WaitForSeconds(audio.clip.length);
	}


	// the sponsored content item, in this case the wheel
	public void selectWheel () {
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = vo0404;
		audio.Play ();
		UI1.SetActive (false);
		UI2.SetActive (false);
		info1.SetActive (false);
		info2.SetActive (false);
		//activates sponsored node
		sponsoredUI.SetActive (true);
		info3.SetActive (true);
	}

	// this takes us out of the showroom and into final voiceover
	public void endExperienceUI() {
		sponsoredUI.SetActive (false);
		info3.SetActive (false);
		StartCoroutine (endExperienceVO ());
		iTween.MoveTo (player, position3.transform.position, 4f);
	}

	IEnumerator endExperienceVO() {
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = vo0407;
		audio.Play ();
		yield return new WaitForSeconds(audio.clip.length);
		audio.clip = vo0408;
		audio.Play ();
		yield return new WaitForSeconds (audio.clip.length);
		endUI.SetActive (true);
	}

	public void restartAll() {
		SceneManager.LoadScene ("Scene_1", LoadSceneMode.Single);
	}


}

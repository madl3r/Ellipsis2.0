using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public GameObject mainMenuObject;
	public Button playButton, optionsButton, quitButton;

	public GameObject optionsMenuObject;
	public Button musicButton, soundFXButton, backButton;

	void Start () {
		playButton.onClick.AddListener(Play);
		optionsButton.onClick.AddListener(Options);
		quitButton.onClick.AddListener(Quit);
		
		musicButton.onClick.AddListener(Music);
		soundFXButton.onClick.AddListener(SoundFX);
		backButton.onClick.AddListener(Back);

		playButton.Select();
	}
	
	void Update () {
		
	}

	void Play()
	{
		Time.timeScale = 1.0f;
		SceneManager.LoadScene("DemoScene1");
	}

	void Options()
	{
		mainMenuObject.SetActive(false);
		optionsMenuObject.SetActive(true);

		backButton.Select();
	}

	void Quit()
	{
		Application.Quit();
		Debug.Log("Quit!");
	}

	void Music()
	{
		// TODO
	}

	void SoundFX()
	{
		// TODO
	}

	void Back()
	{
		optionsMenuObject.SetActive(false);
		mainMenuObject.SetActive(true);

		optionsButton.Select();
	}
}

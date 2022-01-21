using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {

	public GameObject graphicsUI;
	public GameObject moreSettingsUI;

	public void RestartScene() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void OpenGraphicsMenu() {
		graphicsUI.SetActive(true);
	}

	public void CloseGraphicsMenu() {
		graphicsUI.SetActive(false);
	}

	public void OpenMoreSettingsMenu() {
		moreSettingsUI.SetActive(true);
	}

	public void CloseMoreSettingsMenu() {
		moreSettingsUI.SetActive(false);
	}
}

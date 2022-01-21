using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGraphics : MonoBehaviour {

	public GameObject leftJoystick;
	public GameObject leftStick;

	public GameObject rightJoystick;
	public GameObject rightStick;

	public Sprite whiteJoystick;
	public Sprite whiteStick;

	public Sprite blueJoystick;
	public Sprite blueStick;

	public Sprite grayJoystick;
	public Sprite grayStick;

	public void Graphic1() {
		leftJoystick.GetComponent<Image> ().sprite = whiteJoystick;
		leftStick.GetComponent<Image> ().sprite = whiteStick;

		rightJoystick.GetComponent<Image> ().sprite = whiteJoystick;
		rightStick.GetComponent<Image> ().sprite = whiteStick;
	}

	public void Graphic2() {
		leftJoystick.GetComponent<Image> ().sprite = blueJoystick;
		leftStick.GetComponent<Image> ().sprite = blueStick;

		rightJoystick.GetComponent<Image> ().sprite = blueJoystick;
		rightStick.GetComponent<Image> ().sprite = blueStick;
	}

	public void Graphic3() {
		leftJoystick.GetComponent<Image> ().sprite = grayJoystick;
		leftStick.GetComponent<Image> ().sprite = grayStick;

		rightJoystick.GetComponent<Image> ().sprite = grayJoystick;
		rightStick.GetComponent<Image> ().sprite = grayStick;
	}
}

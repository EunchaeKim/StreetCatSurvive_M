using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickRight : MonoBehaviour {

	public GameObject stick;
	public GameObject backgroundImage;
	public GameObject rightAreaForStickyJoystick;
	[Range(1, 10)]
	public int stickMovementThreshold = 4;
	public bool sticky = false;
	public bool moveJoystickBaseOnDrag = false;
	public bool freezeX = false;
	public bool freezeY = false;
	public static float positionX;
	public static float positionY;
	public static float angle;

	Joystick joystick = new Joystick();

	void Start() {
		Init();
	}

	public void Init () {
		joystick.stick = stick;
		joystick.backgroundImage = backgroundImage;
		joystick.stickMovementThreshold = stickMovementThreshold;
		joystick.moveJoystickBaseOnDrag = moveJoystickBaseOnDrag;
		joystick.Start();
		
		if(sticky) {
			backgroundImage.SetActive(false);
			stick.SetActive(false);
			rightAreaForStickyJoystick.SetActive(true);
		}else {
			backgroundImage.SetActive(true);
			stick.SetActive(true);
			rightAreaForStickyJoystick.SetActive(false);
		}
	}
	
	public void Move(BaseEventData data) {
		joystick.Move(data, freezeX, freezeY);
		positionX = joystick.positionX;
		positionY = joystick.positionY;
		angle = joystick.angle;
	}

	public void ReturnToNormalPosition() {
		joystick.ReturnToNormalPosition();
		positionX = joystick.positionX;
		positionY = joystick.positionY;
	}

	//Methods bellow are used if sticky joystick option is enabled
	public void OnStickyPointerDown(BaseEventData data) {
		PointerEventData pointerData = data as PointerEventData;
		backgroundImage.SetActive(true);
		stick.SetActive(true);
		backgroundImage.transform.position = pointerData.position;
	}

	public void OnStickyPointerUp(BaseEventData data) {
		joystick.ReturnToNormalPosition();
		positionX = joystick.positionX;
		positionY = joystick.positionY;
		backgroundImage.SetActive(false);
		stick.SetActive(false);
	}
}

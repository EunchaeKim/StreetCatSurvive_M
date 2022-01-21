using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Threading;
 
public class Joystick {

	public GameObject stick;
	private RectTransform stickRectTransform;
	public GameObject backgroundImage;
	public int stickMovementThreshold = 30;
	public float positionX;
	public float positionY;
	public float angle;
	public bool moveJoystickBaseOnDrag;

	public void Start () {
		if(Screen.width > Screen.height) {
			stickMovementThreshold = stickMovementThreshold * (Screen.width + Screen.height) / 100;
		}else {
			stickMovementThreshold = stickMovementThreshold * (Screen.height + Screen.width) / 100;
		}
		
		stickRectTransform = stick.GetComponent<RectTransform>();
	}

	public void Move(BaseEventData data, bool freezeX, bool freezeY) {
		PointerEventData pointerData = data as PointerEventData;

		float x = backgroundImage.transform.position.x - pointerData.position.x;
		float y = backgroundImage.transform.position.y - pointerData.position.y;

		angle = Mathf.Atan2(x, y);

		float joystickXPosition = x;
		float joystickYPosition = y;

		if(Vector2.Distance(backgroundImage.transform.position, pointerData.position) > stickMovementThreshold) {
			joystickXPosition = stickMovementThreshold * Mathf.Sin(angle);
			joystickYPosition = stickMovementThreshold * Mathf.Cos(angle);
		}

		positionX = -joystickXPosition / stickMovementThreshold;
		positionY = -joystickYPosition / stickMovementThreshold;

		if(freezeX) {
			positionX = 0;
			joystickXPosition = 0;
			joystickYPosition = y;
			if(joystickYPosition > stickMovementThreshold) {
				joystickYPosition = stickMovementThreshold;
			}
			if(joystickYPosition < -stickMovementThreshold) {
				joystickYPosition = -stickMovementThreshold;
			}
		}

		if(freezeY) {
			positionY = 0;
			joystickYPosition = 0;
			if(!freezeX) {
				joystickXPosition = x;
				if(joystickXPosition > stickMovementThreshold) {
					joystickXPosition = stickMovementThreshold;
				}
				if(joystickXPosition < -stickMovementThreshold) {
					joystickXPosition = -stickMovementThreshold;
				}
			}
		}

		stick.transform.position = new Vector2(backgroundImage.transform.position.x - joystickXPosition, backgroundImage.transform.position.y - joystickYPosition);
		x = backgroundImage.transform.position.x - stick.transform.position.x;
		y = backgroundImage.transform.position.y - stick.transform.position.y;
		angle = Mathf.Atan2(x, y);

		if(moveJoystickBaseOnDrag) {
			float joysticXkBaseMovement = backgroundImage.transform.position.x - (stick.transform.position.x - pointerData.position.x);
			float joystickYBaseMovement = backgroundImage.transform.position.y - (stick.transform.position.y - pointerData.position.y);
			if(freezeX) joysticXkBaseMovement = backgroundImage.transform.position.x;
			if(freezeY) joystickYBaseMovement = backgroundImage.transform.position.y;
			backgroundImage.transform.position = new Vector2(joysticXkBaseMovement, joystickYBaseMovement);
		}
	}

	public void ReturnToNormalPosition() {
		stickRectTransform.anchoredPosition = new Vector2(0,0);
		positionX = 0;
		positionY = 0;
	}
}

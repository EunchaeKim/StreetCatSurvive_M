using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

	void Start () {
		Application.targetFrameRate = 300;
	}
	
	void FixedUpdate () {
		if(Vars.option == 1) {
			transform.position  = new Vector3(transform.position.x + JoystickLeft.positionX / 10, transform.position.y, transform.position.z + JoystickLeft.positionY / 10);
			transform.rotation = Quaternion.AngleAxis(Mathf.Rad2Deg * JoystickRight.angle + 180, Vector3.up);
		}else if(Vars.option == 2) {
			transform.position  = new Vector3(transform.position.x + JoystickRight.positionX / 10, transform.position.y, transform.position.z + JoystickRight.positionY / 10);
			transform.rotation = Quaternion.AngleAxis(Mathf.Rad2Deg * JoystickLeft.angle + 180, Vector3.up);
		}else if(Vars.option == 3) {
			transform.position  = new Vector3(transform.position.x + JoystickLeft.positionX / 10, transform.position.y, transform.position.z + JoystickLeft.positionY / 10);
			transform.rotation = Quaternion.AngleAxis(Mathf.Rad2Deg * JoystickLeft.angle + 180, Vector3.up);
		}else if(Vars.option == 4) {
			transform.position  = new Vector3(transform.position.x + JoystickRight.positionX / 10, transform.position.y, transform.position.z + JoystickRight.positionY / 10);
			transform.rotation = Quaternion.AngleAxis(Mathf.Rad2Deg * JoystickRight.angle + 180, Vector3.up);
		}
	}
}

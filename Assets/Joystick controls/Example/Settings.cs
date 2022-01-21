using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

	public GameObject LeftStickMovementTrashold;
	public GameObject LeftSticky;
	public GameObject LeftMoveBaseOnDrag;
	public GameObject LeftFreezeX;
	public GameObject LeftFreezeY;

	public GameObject RightStickMovementTrashold;
	public GameObject RightSticky;
	public GameObject RightMoveBaseOnDrag;
	public GameObject RightFreezeX;
	public GameObject RightFreezeY;

	public GameObject Option1;
	public GameObject Option2;
	public GameObject Option3;
	public GameObject Option4;

	public void LeftStickySettings (){
		JoystickLeft jl = GameObject.Find("joystick").GetComponent<JoystickLeft> ();
		if(LeftSticky.GetComponent<Toggle>().isOn) {
			jl.sticky = true;
			jl.Init();
		}else {
			jl.sticky = false;
			jl.Init();
		}
	}

	public void LeftMoveBaseOnDragSettings (){
		JoystickLeft jl = GameObject.Find("joystick").GetComponent<JoystickLeft> ();
		if(LeftMoveBaseOnDrag.GetComponent<Toggle>().isOn) {
			jl.moveJoystickBaseOnDrag = true;
			jl.Init();
		}else {
			jl.moveJoystickBaseOnDrag = false;
			jl.Init();
		}
	}
	public void LeftFreezeXSettings (){
		JoystickLeft jl = GameObject.Find("joystick").GetComponent<JoystickLeft> ();
		if(LeftFreezeX.GetComponent<Toggle>().isOn) {
			jl.freezeX = true;
			jl.Init();
		}else {
			jl.freezeX = false;
			jl.Init();
		}
	}
	public void LeftFreezeYSettings (){
		JoystickLeft jl = GameObject.Find("joystick").GetComponent<JoystickLeft> ();
		if(LeftFreezeY.GetComponent<Toggle>().isOn) {
			jl.freezeY = true;
			jl.Init();
		}else {
			jl.freezeY = false;
			jl.Init();
		}
	}
	public void LeftStickMovementTrasholdSettings (){
		JoystickLeft jl = GameObject.Find("joystick").GetComponent<JoystickLeft> ();
		jl.stickMovementThreshold = (int)LeftStickMovementTrashold.GetComponent<Slider>().value;
		jl.Init();
	}

////////////////////////////////////////////////////////////////////////////////////////////////RIGHT

	public void RightStickySettings (){
		JoystickRight jr = GameObject.Find("joystick").GetComponent<JoystickRight> ();
		if(RightSticky.GetComponent<Toggle>().isOn) {
			jr.sticky = true;
			jr.Init();
		}else {
			jr.sticky = false;
			jr.Init();
		}
	}

	public void RightMoveBaseOnDragSettings (){
		JoystickRight jr = GameObject.Find("joystick").GetComponent<JoystickRight> ();
		if(RightMoveBaseOnDrag.GetComponent<Toggle>().isOn) {
			jr.moveJoystickBaseOnDrag = true;
			jr.Init();
		}else {
			jr.moveJoystickBaseOnDrag = false;
			jr.Init();
		}
	}
	public void RightFreezeXSettings (){
		JoystickRight jr = GameObject.Find("joystick").GetComponent<JoystickRight> ();
		if(RightFreezeX.GetComponent<Toggle>().isOn) {
			jr.freezeX = true;
			jr.Init();
		}else {
			jr.freezeX = false;
			jr.Init();
		}
	}
	public void RightFreezeYSettings (){
		JoystickRight jr = GameObject.Find("joystick").GetComponent<JoystickRight> ();
		if(RightFreezeY.GetComponent<Toggle>().isOn) {
			jr.freezeY = true;
			jr.Init();
		}else {
			jr.freezeY = false;
			jr.Init();
		}
	}
	public void RightStickMovementTrasholdSettings (){
		JoystickRight jr = GameObject.Find("joystick").GetComponent<JoystickRight> ();
		jr.stickMovementThreshold = (int)RightStickMovementTrashold.GetComponent<Slider>().value;
		jr.Init();
	}

////////////////////////////////////////////////////////////////////////////////////////////////OPTIONS

	public void Option1Settings () {
		Vars.option = 1;
		Option2.GetComponent<Toggle>().isOn = false;
		Option3.GetComponent<Toggle>().isOn = false;
		Option4.GetComponent<Toggle>().isOn = false;
		Invoke("Check1", 0.1f);
	}

	public void Option2Settings () {
		Vars.option = 2;
		Option1.GetComponent<Toggle>().isOn = false;
		Option3.GetComponent<Toggle>().isOn = false;
		Option4.GetComponent<Toggle>().isOn = false;	
		Invoke("Check2", 0.1f);
	}
	public void Option3Settings () {
		Vars.option = 3;
		Option1.GetComponent<Toggle>().isOn = false;
		Option2.GetComponent<Toggle>().isOn = false;
		Option4.GetComponent<Toggle>().isOn = false;
		Invoke("Check3", 0.1f);
	}
	public void Option4Settings () {
		Vars.option = 4;
		Option1.GetComponent<Toggle>().isOn = false;
		Option2.GetComponent<Toggle>().isOn = false;
		Option3.GetComponent<Toggle>().isOn = false;
		Invoke("Check4", 0.1f);
	}

	private void Check1() {
		Option1.GetComponent<Toggle>().isOn = true;
	}

	private void Check2() {
		Option2.GetComponent<Toggle>().isOn = true;
	}

	private void Check3() {
		Option3.GetComponent<Toggle>().isOn = true;
	}

	private void Check4() {
		Option4.GetComponent<Toggle>().isOn = true;
	}
}

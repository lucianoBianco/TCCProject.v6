using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TommySkills : MonoBehaviour {
	public bool skill;
	PlayerMotor motor;
	TargetObj target;
	// Use this for initialization
	void Start () {
		motor = transform.GetComponent<PlayerMotor> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (skill && motor.lockOn) {
			Activate ();
		}
	}



	public void Activate(){
		skill = false;
		motor.lockOn = false;
		target = motor.lockonTarget.GetComponent<TargetObj>();
		target.GetComponent<TommyBoom> ().Boom ();

	}
}

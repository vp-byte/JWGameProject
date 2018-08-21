using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCaremaFollow : MonoBehaviour {

	public float CameraMoveSpeed = 120.0f;
	public GameObject cameraFollower;
	public Vector3 followPosition;
	public float clampAngle =0.0f;
	public float inputSensibility =150.0f;
	public GameObject cameraObject;
	public GameObject playerObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

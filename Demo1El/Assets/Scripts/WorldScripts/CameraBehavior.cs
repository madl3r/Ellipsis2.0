using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour {

	// Script must follow player to different rooms (already implemented in "World" script)
	// Must also handle screen shake.
		// for screen shake must hold a Vector 3 position for the room location that it belongs in
		// this way if multiple things call to shake it can always return to the same anchor point.

	private float cameraYPos;
	private float cameraXPos;
	private float cameraZPos;
	Vector3 camCenterPos;
	float shakeAmt = 0;

	public Camera mainCamera;

	// Use this for initialization
	void Start () {
		cameraXPos = 0.0f;
		cameraYPos = 0.0f;
		cameraZPos = -1.0f;
		camCenterPos = new Vector3 (cameraXPos, cameraYPos, cameraZPos);

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void InvokeShake(int shakePow)
	{
		shakeAmt = shakePow * .025f;
		InvokeRepeating("CameraShake", 0, .01f);
		Invoke("StopShaking", 0.4f);
	}

	void CameraShake()
	{
		if (shakeAmt > 0)
		{
			float quakeAmt = Random.value * shakeAmt * 2 - shakeAmt;
			Vector3 pp = mainCamera.transform.position;
			pp.y += quakeAmt;
			quakeAmt = Random.value * shakeAmt * 2 - shakeAmt;
			pp.x += quakeAmt;
			mainCamera.transform.position = pp;
		}
	}

	void StopShaking()
	{
		CancelInvoke("CameraShake");
		mainCamera.transform.position = camCenterPos;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ruch : MonoBehaviour {
	public Transform MainCamera;
	public int szybkoscGracza;
	private CharacterController cc;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();
	}
	// Update is called once per frame
	void Update () {
		Vector3 forward = MainCamera.TransformDirection (Vector3.forward);
		//forward.y = 0;
		//forward.z = 0;
		if (Input.GetMouseButton(0)) {
			//transform.Translate (Vector3.forward * przodtyl);
			//cc.Move(forward * 0.01f * szybkoscGracza);
			cc.SimpleMove (forward * szybkoscGracza);
		}
		if (Input.GetMouseButton(1)) {
			cc.SimpleMove (forward * szybkoscGracza * -1);

		}
	}
}

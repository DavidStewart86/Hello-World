using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFountain : MonoBehaviour {
	public GameObject cube;
	public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GameObject cube = GameObject.Instantiate (cube, transform.position, Quaternion.identity) as GameObject;

		Rigidbody cubeRigidBody = cube.GetComponent<Rigidbody> ();

		cubeRigidBody.AddForce (cube.transform.up * speed, ForceMode.VelocityChange);
		
	}
}

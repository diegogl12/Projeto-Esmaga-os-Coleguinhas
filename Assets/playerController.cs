using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed;
	public float jump;

	private Rigidbody rb;
	private bool facingRight = true;
	private bool jump = false;
	private anime;
	private bool chao = false;
	private Transform groundCheck;

	// Use this for initialization
	void Start () {

		rb = gameObject.GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

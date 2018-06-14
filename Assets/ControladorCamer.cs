using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamer : MonoBehaviour {

    public GameObject Megaman;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - Megaman.transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate() {
        transform.position = Megaman.transform.position + offset;
    }
}

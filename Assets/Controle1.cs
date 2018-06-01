using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle1 : MonoBehaviour {

    public float velocidade;
    public float força_pulo;

    private Rigidbody2D rb;
    private bool orientadoDireita = true;
    private bool pulo = false;
    private animator anim;
    private bool noChao;
    private Transform checando_chao;


	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<>
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

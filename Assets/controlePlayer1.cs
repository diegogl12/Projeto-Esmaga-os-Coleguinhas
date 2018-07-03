using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlePlayer1 : MonoBehaviour {

    public float speed;
    public float jumpforce;
    private Rigidbody2D rb;
    private bool faceright = true;
    private bool jump = false;
    private Animator anim;
    private bool noChao = false;
    private Transform groundcheck;


	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        groundcheck = gameObject.transform.Find("GroundCheck");
	}
	
	void Update () {
        noChao = Physics2D.Linecast(transform.position, groundcheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if(Input.GetButtonDown("Jump") && noChao)
        {
            jump = true;
            anim.SetTrigger("Pulou");
        }
	}

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("Velocidade", Mathf.Abs(h));

        rb.velocity = new Vector2(h * speed, rb.velocity.y);

        if (h > 0 && !faceright)
            Flip();
        else if (h < 0 && faceright)
            Flip();

        if(jump)
        {
            if(noChao)
                rb.AddForce(new Vector2(0, jumpforce));
            
            jump = false;
        }
    
    }

    void Flip()
    {
        faceright = !faceright;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;

        transform.localScale = theScale;

    }
}

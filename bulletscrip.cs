using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscrip : MonoBehaviour {
	public float speed;
	public float jumpforce;
	public GameObject tiro;
	public Transform tiroSpawn;

	private Rigidbody2D rb;
	private bool faceright = true;
	private bool jump = false;
	private Animator anim;
	private bool noChao = false;
	private Transform groundcheck;
	private Vector3 theScale;



	void Start()
	{
		rb = gameObject.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator>();
		groundcheck = gameObject.transform.Find("GroundCheck");
	}

	void Update()
	{
		noChao = Physics2D.Linecast(transform.position, groundcheck.position, 1 << LayerMask.NameToLayer("Ground"));

		if (Input.GetButtonDown("Jump") && noChao)
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

		if (jump)
		{
			if (noChao)
				rb.AddForce(new Vector2(0, jumpforce));

			jump = false;
		}

		if (Input.GetKeyDown(KeyCode.R))
			Fire();

	}

	void Flip()
	{
		faceright = !faceright;
		theScale = transform.localScale;
		theScale.x *= -1;

		transform.localScale = theScale;

	}

	void Fire()
	{


		anim.SetTrigger("Atirar");

		var shoot = (GameObject)Instantiate(
			tiro,
			tiroSpawn.position,
			tiroSpawn.rotation);
		shoot.transform.localScale = theScale;

		if(faceright)
			shoot.GetComponent<Rigidbody2D>().velocity = Vector2.right * 6;
		else
			shoot.GetComponent<Rigidbody2D>().velocity = Vector2.left * 6;

	
		Destroy(shoot, 2.0f);
	}

    void OnCollisionEnter2D(Collider2D collide)
    {
        if (collide.tag == "mega")
        {
            Destroy(collide);
        }
    }
}

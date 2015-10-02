using UnityEngine;
using System.Collections;

public class RubaScript : MonoBehaviour 
{
	public float upForce;			
	public float forwardSpeed;		
	public bool isDead = false;		

	Animator anim;					
	bool flap = false;				


	void Start()
	{
		anim = GetComponent<Animator> ();

        Vector2 newVel = new Vector2(forwardSpeed, 0);
        GetComponent<Rigidbody2D>().velocity = newVel;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, upForce));
    }

	void Update()
	{
        if (isDead)
			return;

		if (Input.anyKeyDown)
			flap = true;
	}

	void FixedUpdate()
	{

		if (flap) 
		{
			flap = false;
			anim.SetTrigger("Flap");
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, upForce));
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		isDead = true;
		anim.SetTrigger ("Die");
		GameControlScript.current.BirdDied ();
	}
}

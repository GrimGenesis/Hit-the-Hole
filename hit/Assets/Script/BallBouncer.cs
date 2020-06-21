using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BallBouncer : MonoBehaviour
{
	private Rigidbody2D rb;

	Vector3 lastVelocity;
	[SerializeField] GameObject vfx;
	//[SerializeField] GameObject sfx;


	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		lastVelocity = rb.velocity;
	}

	private void OnCollisionEnter2D(Collision2D col)
    {
        Bounce(col);

      //  Obstacle(col);

        BounceSFX();
        BounceVFX();

    }

    private void Bounce(Collision2D col)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, col.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
    }

 /*   private static void Obstacle(Collision2D col)
    {
        if (col.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            Destroy(col.gameObject.);
        }
    }*/

    private void BounceVFX()
    {
		Instantiate(vfx, transform.position, transform.rotation);
    }

	private void BounceSFX()
    {
		GetComponent<AudioSource>().Play();
    }

	

}

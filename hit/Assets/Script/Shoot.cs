using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public float LaunchForce;
    public GameObject Arrow;
	[SerializeField] GameObject vfx;

	void Start()
	{

	}

	void Update()
	{

		if (Input.GetMouseButtonDown(0))
		{
			ShootArrow();
			ShootVFX();
			ShootSFX();

		}
	}

	void ShootArrow()
	{
		GameObject ArrowIns = Instantiate(Arrow, transform.position, transform.rotation);
		ArrowIns.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce);
		
		
	}

	private void ShootSFX()
	{

		GetComponent<AudioSource>().Play();

	}

    private void ShootVFX()
	{
		Debug.Log("blast");
		Instantiate(vfx, transform.position, transform.rotation);
		
	}
}
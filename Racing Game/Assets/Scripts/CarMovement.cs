using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
	public float MaxSpeed;
	public float acc;
	public float steering;

	Rigidbody2D rb;

	float X;
	float Y = 1;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		X = Input.GetAxis("Horizontal");
		
		Vector2 speed = transform.up * (Y * acc);
		rb.AddForce(speed);

		float direction = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up));

		if(acc > 0)
		{
			if(direction > 0)
			{
				rb.rotation -= X * steering * (rb.velocity.magnitude / MaxSpeed);
			}
			else
			{
				rb.rotation += X * steering * (rb.velocity.magnitude / MaxSpeed);
			}
		}

		float driftForce = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.left)) * 2.0f;

		Vector2 relativeForce = Vector2.right * driftForce;

		rb.AddForce(rb.GetRelativeVector(relativeForce));

		if(rb.velocity.magnitude > MaxSpeed)
		{
			rb.velocity = rb.velocity.normalized * MaxSpeed;
		}

		Debug.DrawLine(rb.position, rb.GetRelativePoint(relativeForce), Color.green);
	}
}
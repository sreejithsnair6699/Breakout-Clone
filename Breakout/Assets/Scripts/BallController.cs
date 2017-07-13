using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	Rigidbody2D ballBody;

	void Start () {

		//ballBody = GetComponent<Rigidbody2D> ();

	}

	void Update () {

	}
		

	void OnCollisionEnter2D (Collision2D collide){

		ballBody = GetComponent<Rigidbody2D> ();
			if (collide.gameObject.name == "Paddle") {
			ballBody.velocity = new Vector3 (5f, 5f, 0);
		
			if (transform.position.y - collide.gameObject.transform.position.x < -0.35) {
				ballBody.velocity = new Vector3 (-5f, 5f, 0);
			}

			if (transform.position.y - collide.gameObject.transform.position.x > 0.35) {
				ballBody.velocity = new Vector3 (5f, 5f, 0);
			}
		}

	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

	public GameObject ballBody;
	public GameObject attachBall;
	Rigidbody2D ballRigidBody;
	// Use this for initialization
	void Start () {
		spawnBall ();
		ballRigidBody = attachBall.GetComponent<Rigidbody2D> ();
	}

	void spawnBall(){
		attachBall = (GameObject) Instantiate (ballBody);
	}
	// Update is called once per frame
	void Update () {
		transform.Translate (10f * Time.deltaTime * (Input.GetAxis ("Horizontal")), 0, 0);
		if(ballRigidBody.position.y < -6f) {
			ballRigidBody.position = transform.position + new Vector3 (0f, .16f, 0f);
			attachBall = ballBody;
		}
		if (attachBall){
			
			ballRigidBody.position = transform.position + new Vector3 (0f, .16f, 0f);

			if (Input.GetButtonDown ("Launch")) {
				ballRigidBody.isKinematic = false;
				//ballRigidBody.velocity = new Vector2 (6f * Input.GetAxis ("Horizontal"), 5f);
				BallStartMove();
				attachBall = null;
			}
		}
	}

	void BallStartMove() {

		Vector3 startDirection = new Vector3 ();

		int x_dir = Random.Range (0, 3);

		startDirection.y = 5f;

		if (x_dir == 0) {
			startDirection.x = 5f;
		}

		if (x_dir == 1) {
			startDirection.x = -5f;
		}

		if (x_dir == 2) {
			startDirection.x = 0f;
		}

		ballRigidBody.velocity = startDirection;
	}



}

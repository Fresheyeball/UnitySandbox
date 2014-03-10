using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {

	public float speed;
	public float turnSmoothing = 15f;
	public float speedDampTime = 0.1f;

	private Animator anim;

	void Awake() {
		anim = GetComponent<Animator> ();
	}
		
	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		Vector3 moveit 	     = new Vector3 (h, 0.0f, v);

		rigidbody.velocity = (moveit * speed);

		anim.SetFloat ("speed", h*h+v*v);
	}
}

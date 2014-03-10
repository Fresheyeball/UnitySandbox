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
		float animSpeed = 0;


		if (h != 0 || v != 0) {
//			Vector3 moveit 	   = new Vector3 (0.0f, 0.0f, v);
			rigidbody.AddRelativeTorque(0.0f, h, 0.0f);
			rigidbody.AddForce (transform.forward * speed * v);
			animSpeed  = Mathf.Abs(rigidbody.velocity.z);
			animSpeed /= 40;
		}

		print (animSpeed);

		anim.SetFloat ("speed", animSpeed);
	}
}

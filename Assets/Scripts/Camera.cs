using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public Transform target;
	public float distance;
	public float height;
	public float dampening = 1;
	
	void Update () {
		transform.rotation = Quaternion.Slerp (transform.rotation, target.rotation, dampening);
		Vector3 pos = transform.rotation * Vector3.back * distance + target.position + Vector3.up;
		pos.y += height;
		transform.position = pos;	
	}
}

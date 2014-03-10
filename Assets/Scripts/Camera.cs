using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public Transform target;
	public float distance;
	
	void Update () {
		transform.position = new Vector3 (target.position.x, transform.position.y, target.position.z - distance);		
	}
}

using UnityEngine;
using System.Collections;

public class HomingTest : MonoBehaviour {

	public float verticalSpeed;
	public Transform target;
	private Rigidbody rb;
	private Vector3 force;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		transform.LookAt (target);
		verticalSpeed = Time.timeSinceLevelLoad * 0.01f;
		transform.position += transform.forward * verticalSpeed;
		//force = new Vector3 (verticalSpeed, 0,0);
		//rb.velocity = force;
	}
}

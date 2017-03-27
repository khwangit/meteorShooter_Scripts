using UnityEngine;
using System.Collections;

public class HomingTest : MonoBehaviour {

	public float verticalSpeed;
	public Transform target;
	//private Rigidbody rb;
	private Vector3 force;
	public Vector3 pos;
	public AudioClip st;

	public GameObject arrow;
	public GameObject meteor;
	public GameObject restart;
	public GameObject yScore;
	public GameObject cam;

	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		transform.LookAt (target);
		verticalSpeed = Time.timeSinceLevelLoad * 0.01f;
		transform.position += transform.forward * verticalSpeed;
		//Debug.Log (transform.position);
		//force = new Vector3 (verticalSpeed, 0,0);
		//rb.velocity = force;
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "target") {
			Debug.Log ("hit");

			arrow.SetActive (false);
			meteor.SetActive (false);
			restart.SetActive (true);
			yScore.SetActive (true);

			restart.transform.rotation = cam.transform.rotation;
		}
	}
}

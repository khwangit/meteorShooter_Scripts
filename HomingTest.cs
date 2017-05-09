using UnityEngine;
using System.Collections;

public class HomingTest : MonoBehaviour {

	public float verticalSpeed;
	public Transform target;

	public GameObject meteor;
	public GameObject restart;
	public GameObject yScore;
	public GameObject hScore;
	public GameObject hScoreT;
	public GameObject cam;


	void Update () {
		transform.LookAt (target);
		verticalSpeed = Time.timeSinceLevelLoad * 0.01f;
		transform.position += transform.forward * verticalSpeed;

	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "target") {

			meteor.SetActive (false);
			restart.SetActive (true);
			yScore.SetActive (true);
			hScore.SetActive (true);
			hScoreT.SetActive (true);

			restart.transform.rotation = cam.transform.rotation;
		}
	}
}

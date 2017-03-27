using UnityEngine;
using System.Collections;

public class HitDetector : MonoBehaviour {

	public GameObject meteor;
	public Vector3 pos;

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "target") {
			Debug.Log ("hit");
			pos = new Vector3 (Random.Range(10,20), Random.Range(10,20), Random.Range(10,20));
			Debug.Log (meteor.transform.position);
			Debug.Log (pos);
			meteor.transform.position = pos;
			Debug.Log (meteor.transform.position);
			//Destroy (other.gameObject);
		}
	}
}

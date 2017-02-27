using UnityEngine;
using System.Collections;

public class HitDetector : MonoBehaviour {
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "target") {
			Debug.Log ("hit");
			Destroy (other.gameObject);
		}
	}
}

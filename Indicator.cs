using UnityEngine;
using System.Collections;

public class Indicator : MonoBehaviour {
	void Update () {
		var meteor = GameObject.FindWithTag("meteor").transform;
		transform.LookAt (meteor);
	}
}

using UnityEngine;
using System.Collections;

public class GamController : MonoBehaviour {

	public GameObject meteor;

	// Use this for initialization
	void Awake(){
		Debug.Log ("start!");

		meteor.transform.position = new Vector3 (0, 0, 0);
		meteor.transform.rotation = Random.rotation;
		meteor.transform.position = transform.forward * Random.Range (20, 30);
	}
}

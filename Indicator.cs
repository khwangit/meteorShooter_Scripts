using UnityEngine;
using System.Collections;

public class Indicator : MonoBehaviour {

	public Transform meteor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.ri;
		transform.LookAt (meteor);
	}
}

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public GameObject bullet;
	public float bulletSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			//Debug.Log ("shoot");
			Instantiate(bullet, transform.position, transform.rotation);
		}
	}
}

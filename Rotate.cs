﻿using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	private float speed;
	private float dirx;
	private float diry;
	private float dirz;

	void Awake (){
		speed = Random.Range (1f, 2f);
		dirx = Random.Range (-1f, 1f);
		diry = Random.Range (-1f, 1f);
		dirz = Random.Range (-1f, 1f);
	} 

	void Update () 
	{
		this.transform.Rotate(new Vector3(dirx*speed, diry*speed, dirz*speed));
		//Debug.Log (dirx);
	}
}

using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public AudioClip st;
	public float score;
	public TextMesh scoreT;

	public void awake(){
		score = 0;
	}

	public void OnTarget (){
		Debug.Log ("score!");
		score = score+1;
		scoreT.text = score.ToString(); 
		transform.position = new Vector3 (0, 0, 0);
		transform.rotation = Random.rotation;
		transform.position = transform.forward * Random.Range (20, 30);
		GetComponent<AudioSource>().PlayOneShot(st, 1);
	}
}

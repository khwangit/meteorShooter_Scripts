using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public AudioClip st;
	public float score;
	public TextMesh scoreT;
	public GameObject explotion;
	public GameObject rota;

	public void awake(){
		score = 0;
	}

	public void OnTarget (){
		score = score+1;
		scoreT.text = score.ToString(); 
		Instantiate (explotion, transform.position, transform.rotation);
		GetComponent<AudioSource>().PlayOneShot(st, 1);
		rota.SetActive (false);
		transform.position = new Vector3 (0, 0, 0);
		transform.rotation = Random.rotation;
		transform.position = transform.forward * Random.Range (20, 30);
		rota.SetActive (true);
	}
}

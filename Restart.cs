using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	public void RestartGame(){
		SceneManager.LoadScene ("First", LoadSceneMode.Single);
	}

	public void BackToStart(){
		SceneManager.LoadScene ("Start", LoadSceneMode.Single);
	}

	public void ToCredits(){
		SceneManager.LoadScene ("Credits", LoadSceneMode.Single);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public void OnText (){
		SceneManager.LoadScene ("First", LoadSceneMode.Single);
	}
}

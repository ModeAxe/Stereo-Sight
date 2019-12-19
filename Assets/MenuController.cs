
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartGame(){
		SceneManager.LoadScene ("Level 1");

	}

	public void Test(){
		SceneManager.LoadScene ("Test");
	}

	public void Exit(){

		Application.Quit ();
		
	}
}



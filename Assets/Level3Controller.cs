
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Level3Controller : MonoBehaviour {

	public int ActualLeft;

	public int ActualRight;

	int SoundLeft;

	int SoundRight;

	// Use this for initialization
	void Start () {

		SoundLeft = 0;

		SoundRight = 0;

	
	}
	
	// Update is called once per frame
	void Update () {

		if (ActualLeft < SoundLeft || ActualRight < SoundRight) {
			SoundLeft = 0;
			SoundRight = 0;

            Handheld.Vibrate();

			SceneManager.LoadScene ("Level 3");
		}


		if (SoundLeft == ActualLeft && SoundRight == ActualRight) {

			SceneManager.LoadScene ("Level 4");
		}


		if (Input.touchCount > 0){

			float middle = Screen.width / 2;

			if (Input.GetTouch (0).phase == TouchPhase.Began) {	 

				if (Input.GetTouch (0).position.x < middle && Input.GetTouch (0).phase == TouchPhase.Began) {

					left ();
				}

				if (Input.GetTouch (0).position.x > middle && Input.GetTouch (0).phase == TouchPhase.Began) {

					right ();
				}
			}

		}


	}

	public void left(){
		SoundLeft++;
		Debug.Log ("Left!!");
	}

	public void right(){
		SoundRight++;
		Debug.Log ("Right");


	
	}
}


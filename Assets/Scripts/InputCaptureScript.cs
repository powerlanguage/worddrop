using UnityEngine;
using System.Collections;

public class InputCaptureScript : MonoBehaviour {

	public GameObject LetterSpawner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKeyDown) {
			char inputChar = (char)Input.inputString[0];
			LetterSpawnerScript spawner = LetterSpawner.GetComponent<LetterSpawnerScript>();
			spawner.SpawnLetter(inputChar);
		}
	
	}
}

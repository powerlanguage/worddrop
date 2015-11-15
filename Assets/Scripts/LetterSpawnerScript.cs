using UnityEngine;
using System.Collections;

public class LetterSpawnerScript : MonoBehaviour {

	public GameObject[] alphabet;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.anyKey) {
//			string letter = (string)Input.inputString;
//			char character = letter[0];
//			if(character >= 'a' && character <= 'z') {
//				//Debug.Log (character);
//				int index = char.ToUpper(character) - 'A';
//				GameObject prefab = alphabetPrefabs[index];
//				GameObject newGuy = (GameObject)Instantiate(prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
//			}
//
//		}

		if (Input.GetKeyDown ("space")) {
			float randomX = Random.Range(-5,5);
			Quaternion randomRotation = Quaternion.Euler(0, 0, Random.Range(0,360));
			int randomIndex = (int)Random.Range(0, alphabet.Length);
			GameObject letterPrefab = alphabet[randomIndex];
			GameObject newBox = (GameObject)Instantiate(letterPrefab, new Vector3(randomX, transform.position.y, transform.position.z), randomRotation);
		}
	}
	
}

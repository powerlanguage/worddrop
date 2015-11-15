using UnityEngine;
using System.Collections;

public class LetterSpawnerScript : MonoBehaviour {

	public GameObject[] alphabet;
	public float xForceRange = 100;
	public float maxTorque = 10;
	GameObject newBox;

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
			Vector2 randomForce = new Vector2(Random.Range(-xForceRange,xForceRange), 0);
			Quaternion randomRotation = Quaternion.Euler(0, 0, Random.Range(0,360));
			int randomIndex = (int)Random.Range(0, alphabet.Length);
			GameObject letterPrefab = alphabet[randomIndex];
			newBox = (GameObject)Instantiate(letterPrefab, new Vector3(randomX, transform.position.y, transform.position.z), transform.rotation);
			Rigidbody2D newBoxRigidbody = newBox.GetComponent<Rigidbody2D>();
			newBoxRigidbody.AddForce(randomForce);
			newBoxRigidbody.AddTorque(Random.Range(0,maxTorque));
			Debug.Log(newBox);

		}

		if (Input.GetKeyDown ("return")) {
			if(newBox != null) {
				Vector2 forcey = new Vector2(0,600);
				Debug.Log (newBox.transform.position.y);
				newBox.GetComponent<Rigidbody2D>().AddForce(forcey);
				Debug.Log (newBox.transform.position.y);
			}
		}
	}
	
}

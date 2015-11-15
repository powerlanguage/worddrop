using UnityEngine;
using System.Collections;

public class LetterSpawnerScript : MonoBehaviour {

	public GameObject[] alphabet;
	public float xForceRange = 100;
	public float maxTorque = 10;
	public float xPos;
	public float xIncrement = 5;
	float xStart;
	GameObject newLetter;

	// Use this for initialization
	void Start () {
		xStart = -Camera.main.orthographicSize;
		xPos = xStart;
	}

	public void SpawnLetter(char optional = 'c'){

		//Increment xPos
		float letterX = xPos;
		xPos += xIncrement;
		if (xPos > Camera.main.orthographicSize) {
			xPos = xStart;
		}

		//Set starting values
		Vector2 randomForce = new Vector2(Random.Range(0,xForceRange), 0);
		Quaternion randomRotation = Quaternion.Euler(0, 0, Random.Range(0,360));

		//Instantiate
		int letterIndex = optional - 97;
		GameObject letterPrefab = alphabet[letterIndex];
		newLetter = (GameObject)Instantiate(letterPrefab, new Vector3(letterX, transform.position.y, transform.position.z), transform.rotation);

		//Add torque
		Rigidbody2D newBoxRigidbody = newLetter.GetComponent<Rigidbody2D>();
		newBoxRigidbody.AddForce(randomForce);
		newBoxRigidbody.AddTorque(Random.Range(0,maxTorque));
		Debug.Log(newLetter);
	}
	
}

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

	}

	public void SpawnLetter(char optional = 'c'){

		int letterIndex = optional - 97;
		Debug.Log (letterIndex);

		float randomX = Random.Range(-5,5);
		Vector2 randomForce = new Vector2(Random.Range(-xForceRange,xForceRange), 0);
		Quaternion randomRotation = Quaternion.Euler(0, 0, Random.Range(0,360));
		int randomIndex = (int)Random.Range(0, alphabet.Length);
		GameObject letterPrefab = alphabet[letterIndex];
		newBox = (GameObject)Instantiate(letterPrefab, new Vector3(randomX, transform.position.y, transform.position.z), transform.rotation);
		Rigidbody2D newBoxRigidbody = newBox.GetComponent<Rigidbody2D>();
		newBoxRigidbody.AddForce(randomForce);
		newBoxRigidbody.AddTorque(Random.Range(0,maxTorque));
		Debug.Log(newBox);
	}
	
}

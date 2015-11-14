using UnityEngine;
using System.Collections;

public class CreateBox : MonoBehaviour {

	public GameObject boxPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			float randomX = Random.Range(-5,5);
			Quaternion randomRotation = Quaternion.Euler(0, 0, Random.Range(0,360));
			GameObject newBox = (GameObject)Instantiate(boxPrefab, new Vector3(randomX, transform.position.y, transform.position.z), randomRotation);
		}
	}
	
}

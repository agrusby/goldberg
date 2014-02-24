using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	public Transform sphere1;

	void OnTriggerEnter(Collider other) {
		Instantiate (sphere1, new Vector3 (-10f, 10f, -10f), Quaternion.identity);
		Destroy (other.gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	public Transform sphere1;

	void OnTriggerEnter(Collider other) {
		Instantiate (sphere1, new Vector3 (-15.43653f, 17.19982f, 10.90447f), Quaternion.identity);
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

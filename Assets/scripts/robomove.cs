using UnityEngine;
using System.Collections;

public class robomove : MonoBehaviour {

	public bool on = false;

	void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject);
		on = true;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (on == true) {
			transform.Translate(Vector3.forward * Time.deltaTime);
				}
	
	}
}

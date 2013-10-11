using UnityEngine;
using System.Collections;

public class BackgroundCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		GameObject.DestroyObject(other.gameObject);
	}
}

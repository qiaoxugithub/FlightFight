using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	
	public Transform bomb;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -20.0f || transform.position.y < -15.0f) {
			GameObject.DestroyObject(gameObject);
		}
	}
	
	void OnHit() {
		Debug.Log("Hit");
		Instantiate(bomb, transform.position, Quaternion.identity);
		GameObject.DestroyObject(gameObject);
	}
}

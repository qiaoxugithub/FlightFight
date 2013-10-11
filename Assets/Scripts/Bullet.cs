using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public float speed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
	}
	
	void OnCollisionEnter(Collision collisionInfo) {
		Debug.Log(collisionInfo.collider.name);
	}
}

using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {
	
	public float speed = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector3(-Time.deltaTime * speed, 0.0f, 0.0f));
	}
}

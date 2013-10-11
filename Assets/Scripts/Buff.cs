using UnityEngine;
using System.Collections;

public class Buff : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(Vector3.up, Time.deltaTime * 30.0f); 
		this.transform.Translate((new Vector3(-3.0f * Time.deltaTime, 0, 0)), Space.World);
	}
}

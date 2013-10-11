using UnityEngine;
using System.Collections;

public class TimerRemove : MonoBehaviour {
	
	public float time = 3.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time < 0.0f) {
			GameObject.DestroyObject(gameObject);
		}
	}
}

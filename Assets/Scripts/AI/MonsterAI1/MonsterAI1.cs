using UnityEngine;
using System.Collections;

public class MonsterAI1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.AddComponent<MonsterStateWait>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnStateLeave(string stateName) {
		Debug.Log("----------on state leave + " + stateName);
	}
}

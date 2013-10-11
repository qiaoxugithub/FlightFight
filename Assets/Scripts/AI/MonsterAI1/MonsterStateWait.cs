using UnityEngine;
using System.Collections;

public class MonsterStateWait : MonsterState {
	
	public float waitTime = 1.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		waitTime -= Time.deltaTime;
		if (waitTime < 0.0f) {
			this.enabled = false;
			gameObject.AddComponent<MonsterStateRunToPlayer>();
		}
	}
}

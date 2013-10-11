using UnityEngine;
using System.Collections;

public class MonsterBullet2 : MonoBehaviour {
	
	public float speed = 6.0f;
	public float accel = 9.8f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		speed += accel * Time.deltaTime;
		this.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
		
		if (this.transform.position.x < -20.0f) {
			GameObject.DestroyObject(this.gameObject);
		}
	}
}

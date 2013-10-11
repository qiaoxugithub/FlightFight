using UnityEngine;
using System.Collections;

public class PlayerBullet0 : MonoBehaviour {
	
	public float speed = 10.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
		if (transform.position.x > 20.0f) {
			GameObject.DestroyObject(gameObject);
		}
	}
	
	void OnTriggerEnter(Collider collider) {
		if (collider.tag == "Monster") {
			GameObject.DestroyObject(gameObject);
			//GameObject.DestroyObject(collider.gameObject);
			collider.transform.parent.SendMessage("OnHit");
		}
	}
}

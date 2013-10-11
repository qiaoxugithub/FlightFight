using UnityEngine;
using System.Collections;

public class MonsterBullet3 : MonoBehaviour {
	
	public Vector3 initSpeed;
	public float gravity = -9.8f;
	private Vector3 m_CurSpeed;
	
	// Use this for initialization
	void Start () {
		m_CurSpeed = initSpeed; 
	}
	
	// Update is called once per frame
	void Update () {
		m_CurSpeed += new Vector3(0, gravity, 0) * Time.deltaTime;
		this.transform.Translate(m_CurSpeed * Time.deltaTime);
		
		if (this.transform.position.x < -20.0f || this.transform.position.y < -12.0f) {
			GameObject.DestroyObject(this.gameObject);
		}
	}
}

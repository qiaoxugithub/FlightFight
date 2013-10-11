using UnityEngine;
using System.Collections;

public class MonsterAI2 : MonoBehaviour {
	
	public float moveSpeed = 3.0f;
	public float upSpeed = 3.0f;
	public float shootTime = 1.5f;
	public Transform bullet;
	
	private float m_CurShootTime = 0.0f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		m_CurShootTime -= Time.deltaTime;
		if (m_CurShootTime < 0.0f) {
			m_CurShootTime = shootTime;
			
			Transform blt = Instantiate(bullet) as Transform;
			if (blt) {
				blt.position = this.transform.position;
			}
		}
		this.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, upSpeed * Time.deltaTime, 0));
		
		if (this.transform.position.y > 8.0f || this.transform.position.y < -8.0f) {
			upSpeed *= -1.0f;
		} 
	}
}

using UnityEngine;
using System.Collections;

public class BulletEmitter : MonoBehaviour {
	
	public GameObject bulletPrefab;
	public float deltaTime = 1.0f;
	public float speed = 5.0f;
	private float m_LastCreateTime;
	private GameObject m_Player;
	// Use this for initialization
	void Start () {
		m_Player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - m_LastCreateTime > deltaTime) {
			m_LastCreateTime = Time.time;
			Shoot ();
		}
	}
	
	void Shoot() {
		if (!m_Player)
			return;
		
		GameObject bullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
		bullet.transform.parent = m_Player.transform;
		//bullet.transform.localPosition = this.transform.parent.localPosition;
		Bullet bltCom = bullet.GetComponent<Bullet>();
		if (bltCom) {
			bltCom.speed = speed;
		}
	}
}

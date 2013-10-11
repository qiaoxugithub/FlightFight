using UnityEngine;
using System.Collections;

public class MonsterStateRunToPlayer : MonsterState {
	
	public float speed = 0.0f;
	public float accel = 9.8f;
	
	private GameObject m_Player;
	private Vector3 m_TargetDir;
	// Use this for initialization
	void Start () {
		m_Player = GameObject.Find("Player");
		m_TargetDir = m_Player.transform.position - this.transform.position;
		m_TargetDir.Normalize();
	}
	
	// Update is called once per frame
	void Update () {
		speed += Time.deltaTime * accel;
		this.transform.Translate(m_TargetDir * speed * Time.deltaTime);
	}
}

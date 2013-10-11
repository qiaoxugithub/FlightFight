using UnityEngine;
using System.Collections;

public class MonsterAI3 : MonoBehaviour {
	
	enum STATE {
		STATE_IN,
		STATE_ATTACK,
		STATE_LEAVE,
	}
	
	public float moveSpeed = 3.0f;
	public float attackStateTime = 10.0f;
	public float attackDeltaTime = 2.0f;
	public Transform attackBullet;
	
	private STATE m_State = STATE.STATE_IN;
	private float m_TargetPos = 0.0f;
	private float m_AttackLeftTime = 0.0f;
	// Use this for initialization
	void Start () {
		m_TargetPos = Random.Range(5, 10);
	}
	
	// Update is called once per frame
	void Update () {
		switch (m_State) {
		case STATE.STATE_IN: {
			this.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
			if (this.transform.position.x < m_TargetPos) {
				m_State = STATE.STATE_ATTACK;
			}
		}break;
		case STATE.STATE_ATTACK:{
			attackStateTime -= Time.deltaTime;
			if (attackStateTime < 0.0f) {
				m_State = STATE.STATE_LEAVE;
			} else {
				m_AttackLeftTime -= Time.deltaTime;
				if (m_AttackLeftTime < 0.0f) {
					m_AttackLeftTime = attackDeltaTime;
					
					Transform blt = Instantiate(attackBullet) as Transform;
					if (blt) {
						blt.position = this.transform.position;
					}
				}
			}
		}break;
		case STATE.STATE_LEAVE:{
			this.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
			if (this.transform.position.x < -20.0f) {
				GameObject.DestroyObject(this.gameObject);
			}
		}break;
		}
	}
}

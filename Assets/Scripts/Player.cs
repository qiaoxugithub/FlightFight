using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public Transform normalBullet;
	public float normalAttackTime = 0.3f;
	private float m_NormalAttackTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		m_NormalAttackTime -= Time.deltaTime;
		if (m_NormalAttackTime < 0.0f) {
			m_NormalAttackTime = normalAttackTime;
			NormalAttack();
		}
		
		float dir = Input.GetAxis("Vertical");
		if (dir == 1.0) {
			transform.Translate(new Vector3(0.0f, dir * Time.deltaTime * 3.0f, 0));
		} else if (dir ==-1.0) {
			transform.Translate(new Vector3(0.0f, dir * Time.deltaTime * 3.0f, 0));
		}
		
		float mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
		if (mousePos < -9.0f) {
			mousePos = -9.0f;
		} else if (mousePos > 9.0f) {
			mousePos = 9.0f;
		}
		
		transform.position = new Vector3(transform.position.x, mousePos, 0);
	}
	
	void NormalAttack() {
		if (normalBullet)	{
			Transform blt = Instantiate(normalBullet) as Transform;
			if (blt) {
				blt.position = transform.position;
			}
		}
	}
	
	void OnTriggerEnter(Collider collider) {
		Debug.Log("player collider " + collider.name);
		if (collider.tag == "Buff") {
			GameObject.DestroyObject(collider.gameObject);
		}
	}
}

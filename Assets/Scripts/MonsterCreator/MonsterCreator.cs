using UnityEngine;
using System.Collections;

public class MonsterCreator : MonoBehaviour {
	
	public Transform monsterPrefab;
	public float minCreateTime = 0.0f;
	public float maxCreateTime = 6.0f;
	public Vector2 rangeY;
	public Vector2 rangeX;
	
	private float m_NextTime = 0.0f;
	// Use this for initialization
	void Start () {
		m_NextTime = Random.Range(minCreateTime, maxCreateTime);
	}
	
	// Update is called once per frame
	void Update () {
		m_NextTime -= Time.deltaTime;
		if (m_NextTime < 0.0f) {
			CreateMonster();
			m_NextTime = Random.Range(minCreateTime, maxCreateTime);
		}
	}
	
	Transform CreateMonster() {
		if (monsterPrefab) {
			Transform monster = Instantiate(monsterPrefab, new Vector3(Random.Range(rangeX.x, rangeX.y), Random.Range(rangeY.x, rangeY.y), 0), Quaternion.identity) as Transform;
			return monster;
		}
		
		return null;
	}
}

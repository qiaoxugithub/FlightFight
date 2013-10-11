using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {
	
	public Camera mainCamera;
	public Transform[] segments;
	
	private float speed = 2.0f;
	private double m_Aspect = 1.0;
	private Transform m_Fighter = null;
	private float m_LastCreate = 0.0f;
	
	// Use this for initialization
	void Start () {
		m_Aspect = Screen.width / Screen.height;
		m_Fighter = this.transform.FindChild("Fighter");
	}
	
	// Update is called once per frame
	void Update () {
		float timeDiff = Time.deltaTime;
		
		this.transform.Translate(new Vector3(0, timeDiff * speed, 0));
		
		float d = Input.GetAxis("Horizontal");
		if (d != 0.0f) {
			if (m_Fighter) {
				m_Fighter.transform.Translate(new Vector3((d > 0.0f ? 1.0f : -1.0f) * timeDiff * 5, 0, 0));
			}
		}
		
		if (Time.time - m_LastCreate > 5.0f) {
			int index = Random.Range(0, segments.Length);
			Vector3 pos = new Vector3(0, transform.position.y + 10, 0);
			Transform inst = Instantiate(segments[index], pos, Quaternion.identity) as Transform;
			inst.parent = this.transform;
			m_LastCreate = Time.time;
		}
	}
}

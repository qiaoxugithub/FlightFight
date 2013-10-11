using UnityEngine;
using System.Collections;

public class TurnToPlayer : MonoBehaviour {
	
	private GameObject m_Player;
	// Use this for initialization
	void Start () {
		m_Player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

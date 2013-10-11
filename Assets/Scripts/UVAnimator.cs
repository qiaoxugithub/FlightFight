using UnityEngine;
using System.Collections;

public class UVAnimator : MonoBehaviour {
	
	public float scrollSpeed = 0.1f;
	
	private float offsetX = 0.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//float frame = Mathf.Floor(Time.time * scrollSpeed);
		//offsetX = frame / countX;
		//offsetY = -(frame - frame % count);
		offsetX += Time.deltaTime * scrollSpeed;
		
		renderer.material.SetTextureOffset("_MainTex", new Vector2(offsetX, 0.0f));
	}
}
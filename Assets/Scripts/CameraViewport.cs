using UnityEngine;
using System.Collections;

public class CameraViewport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rect rect = new Rect();
		rect.x = 0.0f;
		rect.y = 0.0f;
		rect.width = 0.5f;
		rect.height = 0.1f;
		
		camera.rect = GetRect();
	}
	
	// Update is called once per frame
	void Update () {
		camera.rect = GetRect();
	}
	
	Rect GetRect() {
		Rect rect = new Rect();
		rect.x = 0.0f;
		rect.y = 0.0f;
		rect.width = 1.0f;
		rect.height = 1.0f;
		
		float tgtAsp = 16.0f / 10.0f;
		float newWidth = Screen.height * tgtAsp;
		float newHeight = Screen.width / tgtAsp;
		if (newWidth < Screen.width) {
			rect.width = newWidth / Screen.width;
			rect.height = 1.0f;
			rect.x = (1.0f - rect.width) / 2.0f;
		} else if (newHeight < Screen.height) {
			rect.width = 1.0f;
			rect.height = newHeight / Screen.height;
			rect.y = (1.0f - rect.height) / 2.0f;
		}

		return rect;
	}
}

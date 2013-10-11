using UnityEngine;
using System.Collections;

public class SegmentCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (IsOutRange()) {
		//	GameObject.DestroyObject(this.gameObject);
		//}
		if (this.transform.childCount == 0) {
			GameObject.DestroyObject(this.gameObject);
		}
	}
	
	bool IsOutRange() {
		for (int i = 0; i < this.transform.childCount; i++) {
			Transform child = this.transform.GetChild(i);
			if (child.transform.localPosition.y > -20) {
				return false;
			}
		}
		
		return true;
	}
}

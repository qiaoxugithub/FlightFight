using UnityEngine;
using System.Collections;

public class PlantCreator : MonoBehaviour {
	
	public Transform[] plantPrefab;
	
	private float leftTime = 0.0f;
	private GameObject plants;
	// Use this for initialization
	void Start () {
		plants = GameObject.Find("Plants");
	}
	
	// Update is called once per frame
	void Update () {
		leftTime -= Time.deltaTime;
		
		if (leftTime < 0.0f) {
			leftTime = Random.Range(2.0f, 8.0f);
			CreatePlant();
		}
	}
	
	void CreatePlant() {
		if (plantPrefab.Length > 0) {
			int index = Random.Range(0, plantPrefab.Length);
			Transform newPlant = Instantiate(plantPrefab[index], new Vector3(18, 0, 0), Quaternion.identity) as Transform;
			if (newPlant) {
				newPlant.parent = plants.transform;
				
				Vector3 local = newPlant.transform.localPosition;
				local.z = 0.0f;
				newPlant.localPosition = local;
			}
		}
	}
}

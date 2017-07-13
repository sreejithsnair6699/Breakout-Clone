using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksSpawn : MonoBehaviour {

	public GameObject blue, red, yellow, green;
	float posZ1 = -7f, posZ2 = -6.4f;
	// Use this for initialization
	void Start () {
		for(int i = 1; i < 17; i++) {
			Instantiate( blue, new Vector3(posZ1, 2.2f, 0f), Quaternion.identity);
			Instantiate( red, new Vector3(posZ1, 1.4f, 0f), Quaternion.identity);
			posZ1 += .95f;
		}
		for(int i = 1; i < 16; i++) {
			Instantiate( green, new Vector3(posZ2, 1.8f, 0f), Quaternion.identity);
			Instantiate( yellow, new Vector3(posZ2, 1f, 0f), Quaternion.identity);
			posZ2 += .95f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}

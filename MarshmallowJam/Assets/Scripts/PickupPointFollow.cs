using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPointFollow : MonoBehaviour {
    public GameObject papa;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = new Vector3(papa.transform.position.x, papa.transform.position.y + 0.79f, papa.transform.position.z);


		
	}
}

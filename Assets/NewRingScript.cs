using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(new Vector3(5, 5, 5), new Vector3(0, 1, 0), 200 * Time.deltaTime);
    }
}

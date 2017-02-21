using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewJumpScript : MonoBehaviour {

    int upFlag = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 13)
        {
            upFlag = -1;
        }
        if (transform.position.y < -3)
        {
            upFlag = 1;
        }
        Vector3 moveDirection = new Vector3(0, 10 * upFlag * Time.deltaTime, 0);
        transform.Translate(moveDirection);
       

    }
}

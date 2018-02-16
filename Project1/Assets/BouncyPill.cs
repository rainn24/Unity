using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyPill : MonoBehaviour {


    // variable to store height
    float h;
    Vector3 OrigPos;

    // Variable to store speed
    float vel;
    // Use this for initialization
    void Start () {
        transform.position = new Vector3(0,1,0);
        OrigPos = gameObject.transform.position;
        vel = 0;

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = OrigPos + new Vector3(0, Mathf.Sin(Time.time), 0);

	}
}

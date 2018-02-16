using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyPill : MonoBehaviour {


    // variable to store height
    float h;
    Vector3 OrigPos;
    public GameObject EnviroPlane;
    // Variable to store speed
    //float vel;
    // Use this for initialization
    void Start () {
        transform.position = EnviroPlane.transform.position+ Vector3.up*2;
        OrigPos = gameObject.transform.position;
        //vel = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
        // Standard position based on shifting coordinate
        //transform.position = OrigPos + new Vector3(0, Mathf.Sin(Time.time), 0);
       gameObject.transform.Translate(new Vector3(0f, Mathf.Sin(Time.time), 0f));
	}
}

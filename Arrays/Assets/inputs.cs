using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardinputs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))  //important infomation//
        {
            print("I hit A");
       
        }
	}
}

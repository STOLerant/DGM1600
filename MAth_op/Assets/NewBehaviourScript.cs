﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public int addition = 12 + 4;
    public int subtraction = 12 - 4;
    public float division = 5.0f / 2.0f;
    public int multiplication = 10 * 2;
    public int remainder = 7 % 2; 


	// Use this for initialization
	void Start () {
        addition += 9;// += adds to
        subtraction -= 10; // subtract from
        addition += 3;
        addition = 1;


	}
	
}

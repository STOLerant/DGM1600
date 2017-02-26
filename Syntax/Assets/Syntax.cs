using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour {


    // all variables start with lower case, if multiple words, the following words anre camelCased
    // variable names can only start with a letter or an underscore
    public string myString = "Hello World"; // strings must have quotation marks
    public int myInt = 1; // ints are whole numbers, either positive or negitive
    public float myFloat = 1.2f; // floats require an f
    public bool myBool = false; // denotes T or F

	// Use this for initialization
	void Start () {
        print("Hello");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelse : MonoBehaviour {


    public string password;
    public bool UserAgreement;

	// Use this for initialization
	void Start () {

           if(password == "OU812"  || UserAgreement)
        {
            print("Correct");
        }
           else
        {
            print("Incorrect");
        }
	}

}

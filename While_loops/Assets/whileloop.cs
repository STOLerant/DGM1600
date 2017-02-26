using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileloop : MonoBehaviour {

    int i = 0;
    public string[] colors;
	// Use this for initialization
	void Start () {
		
         while(i < colors.Length)
        {
            print(colors[i]);
            i++;
        }
        print("Ding! It's Done!");
	}
}

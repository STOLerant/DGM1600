using System;
using UnityEngine;

public class Variables : MonoBehaviour {

	// Use this for initialization
	void Start () {
        {
            short a;
            int b;
            double c;

            /* actual initialization */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
    }
}

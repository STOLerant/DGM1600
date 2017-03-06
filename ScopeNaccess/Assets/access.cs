using UnityEngine;
using System.Collections;

public class access : MonoBehaviour {

    public Scope home;
	
	// Update is called once per frame
	void Start () {
        print(home.owner);
        //print(home.Awake());
        home.Awake();
    }
}

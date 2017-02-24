using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class lists : MonoBehaviour {

    public string myWeapon;
    public List<string> myWeaponList;
    public string[] myWeaponArray;


	void Start () {
        myWeaponList.Add("Sword");
        //myWeaponList.Remove("Piece of Ham");
        myWeaponList.Add("Bow");
        //myWeaponList.RemoveAt(1);

         
		
	}

    public Void AddToList (myWeapon)
    {
        myWeaponList.Add("Rock");
    }
}

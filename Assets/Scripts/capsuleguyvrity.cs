using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This is Marissa's first script!
public class capsuleguyvrity : MonoBehaviour {

    Rigidbody poop;

	// Use this for initialization
	void Start () {
        poop = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        // If someone left clicks, do...
		if (Input.GetButtonDown("Fire1"))
        {
            poop.useGravity = false;
            Debug.Log("poopening");
        }
        if (Input.GetButtonDown("Fire2"))
        {
            poop.useGravity = true;
            Debug.Log("farewell interstellar steedman");
        }
	}
}

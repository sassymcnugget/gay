using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekuShadow : MonoBehaviour {
    public GameObject shadow;
    
	// Update is called once per frame
	void Update () {
        shadow.transform.position = new Vector3(transform.position.x,0.05f,transform.position.z);
	}
}

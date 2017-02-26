using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCanvas : MonoBehaviour {
    public static Canvas mainCanvas;

	// Use this for initialization
	void Start () {
        mainCanvas = GetComponent<Canvas>();
	}
}

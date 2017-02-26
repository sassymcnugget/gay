using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour {
    public List<string> dialogueList;
    GameObject canvas;
    private Text mainText;

	// Use this for initialization
	void Start () {
        canvas = GameObject.FindGameObjectWithTag("MainCanvas");
        mainText = canvas.GetComponentInChildren<Text>();

        mainText.text = dialogueList[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

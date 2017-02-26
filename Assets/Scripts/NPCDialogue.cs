using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour {
    public List<string> dialogueList;
    public GameObject speechBubblePrefab;
    private int dialogueIndex = 0;
    private Canvas canvas;
    private Text mainText;

	// Use this for initialization
	void Start () {
        canvas = StaticCanvas.mainCanvas;
        mainText = canvas.gameObject.GetComponentInChildren<Text>();
        
        mainText.text = dialogueList[dialogueIndex];
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && dialogueIndex < dialogueList.Count)
        {
            GameObject spawnedBubble = Instantiate(speechBubblePrefab, transform.position, transform.rotation);
            //spawnedBubble.GetComponent<SpeechBubbleScript>().setBubbleType(1);
            spawnedBubble.transform.SetParent(canvas.gameObject.transform, false);
            spawnedBubble.GetComponentInChildren<Text>().text = dialogueList[dialogueIndex];
            spawnedBubble.transform.position = new Vector3(spawnedBubble.transform.position.x, 
                spawnedBubble.transform.position.y + 100f, spawnedBubble.transform.position.z);

            mainText.text = dialogueList[dialogueIndex];
            dialogueIndex = (dialogueIndex+1) % dialogueList.Count;
        }
	}
}

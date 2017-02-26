using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechBubbleScript : MonoBehaviour {
    public List<Sprite> speechBubbleTypes = new List<Sprite>();
    private Image bubble;

    private void Start()
    {
        bubble = GetComponent<Image>();
    }

    // Use this for initialization
    public void setBubbleType (int type) {
        if (type < speechBubbleTypes.Count)bubble.sprite = speechBubbleTypes[type];
        else Debug.Log("Invalid Speech Bubble Type used at: " + gameObject.name);
	}
}

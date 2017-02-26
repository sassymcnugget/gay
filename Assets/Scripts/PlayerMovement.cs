using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 10;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody rig;

	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        if(animator != null)setAnimation(hAxis, vAxis);
        rig.MovePosition(transform.position + movement);
	}

    void setAnimation(float hAxis, float vAxis)
    {
        if (hAxis != 0 || vAxis != 0)
        {
            animator.SetFloat("vAxis", vAxis);
            animator.SetFloat("hAxis", hAxis);

            if (hAxis < 0) spriteRenderer.flipX = false;
            else spriteRenderer.flipX = true;
        }
        else
        {
        }
    }
}

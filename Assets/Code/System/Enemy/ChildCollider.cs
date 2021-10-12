﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("InvisBar")) {
            transform.parent.GetComponent<EvilMageAI>().CollisionDetectedInvisWall(this);
        }
    }
    void OnCollisionEnter2D(Collision2D collision) {
        
        transform.parent.GetComponent<EvilMageAI>().CollisionDetected(this);
    }
}

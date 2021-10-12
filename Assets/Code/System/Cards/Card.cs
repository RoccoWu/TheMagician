﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private Vector3 start;

    private float lastMove;
    private float deltaTime;

    bool goingUp = true;

    public float moveSpeed = 0.05f;

    // Use this for initialization
    void Start()
    {
        start = transform.position;
        lastMove = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        hover();
        //checkForCol();
    }

    private void hover()
    {
        deltaTime = Time.time - lastMove;
        if (deltaTime > .1)
        {
            if (goingUp)
            {
                if (start.y + .5 >= transform.position.y)
                {
                    transform.position += new Vector3(0, moveSpeed, 0);
                }
                else
                {
                    goingUp = !goingUp;
                }
            }
            else
            {
                if (start.y < transform.position.y)
                {
                    transform.position += new Vector3(0, -moveSpeed, 0);
                }
                else
                {
                    goingUp = !goingUp;
                }
            }
            lastMove = Time.time;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            GameManager.newCards++;
            Destroy(this.gameObject);
            cards.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public GameObject cards;
    private void checkForCol()
    {
        if (Mathf.Abs(GameManager.playerPos.x - transform.position.x) < 0.5 ||
            Mathf.Abs(transform.position.x - GameManager.playerPos.x) < 0.5)
        {


            if (Mathf.Abs(GameManager.playerPos.y - transform.position.y) < 0.5 ||
            Mathf.Abs(transform.position.y - GameManager.playerPos.y) < 0.5)
            {
                GameManager.newCards++;
                Destroy(this.gameObject);
                cards.SetActive(true);
                Time.timeScale = 0;

            }

        }
    }
}


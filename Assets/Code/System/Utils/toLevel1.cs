using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLevel1 : MonoBehaviour
{
   // public string
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col) // col is the trigger object we collided with
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("To Next Level");
            SceneManager.LoadScene("Level1Castle");
            GameObject thePlayer = GameObject.Find("Player");
            GameManager.health = 100f;
        }
        
    }
}

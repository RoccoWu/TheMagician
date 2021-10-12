using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashManager : MonoBehaviour
{

    public BoxCollider2D[] DashBoxes;
    // Start is called before the first frame update
    void Start()
    {
        DashBoxes = GetComponentsInChildren<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
     if(GameManager.Activated == true)
        {
            for (int i = 0; i<DashBoxes.Length;i++)
            {
                DashBoxes[i].enabled = false;
            }
        }
     else
        {
            for (int i = 0; i < DashBoxes.Length; i++)
            {
                DashBoxes[i].enabled = true;
            }
        }
    }
}

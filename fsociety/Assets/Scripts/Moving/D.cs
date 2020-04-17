using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D : MonoBehaviour
{
    public GameObject player;
    

    bool InCell = false;

    float step = 0.1f;

    private void OnMouseDown()
    {
        InCell = true;
    }

    private void OnMouseExit()
    {
        InCell = false;
    }
    private void OnMouseUp()
    {
        InCell = false;
    }

    private void FixedUpdate()
    {
        if (InCell)
        {
            Vector3 temp = new Vector3(step,0);
            player.transform.position += temp;
        }
    }
}


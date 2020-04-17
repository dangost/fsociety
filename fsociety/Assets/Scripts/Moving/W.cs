using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W : MonoBehaviour
{
    public GameObject player;

    public Rigidbody2D rd;
    float jumpForce = 7f;
    /*bool InCell = false;

    float step = 10f;

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
        if(InCell)
        {
            Vector3 temp = new Vector3(0, step);
            player.transform.position += temp;
        }
    }*/

    private void OnMouseDown()
    {
        Space();
    }

    void Space()
    {
        rd.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePC : MonoBehaviour
{

    public GameObject player;
    public Rigidbody2D ghost;
    public GameObject mainCamera;

    float step = 0.05f;
    float jumpForce = 10f;
    bool IsGround = true;

    bool faceRight = true;

    bool lastKeyflip = false;

    // Start is called before the first frame update
    void Start()
    {
        ghost = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempe = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        mainCamera.transform.position = tempe;
        if(Input.GetKey(KeyCode.D))
        {            
            Vector3 temp = new Vector3(step,0,0);
            player.transform.position += temp;
            
        }

        if (Input.GetKey(KeyCode.A))
        {            
            Vector3 temp = new Vector3(-1*step, 0, 0);
            player.transform.position += temp;
        }

        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            if(Input.GetKeyDown(KeyCode.A))
            {
                lastKeyflip = false;
                if (faceRight != lastKeyflip)
                {
                    Flip();
                }
            }

            else if(Input.GetKeyDown(KeyCode.D))
            {
                lastKeyflip = true;
                if (faceRight != lastKeyflip)
                {
                    Flip();
                }
            }

            Flip();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Space();
        }
    }

    private void FixedUpdate()
    {
    }

    void Space()
    {
        ghost.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    void Flip()
    {
        faceRight = !faceRight;

        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject player;
    public GameObject W, A, D;

    void Update()
    {
        Vector3 temp0 = new Vector3(player.transform.position.x, player.transform.position.y, mainCamera.transform.position.z);
        mainCamera.transform.position = temp0;

        Vector3 tempW = new Vector3(player.transform.position.x + 7.16f, player.transform.position.y - 2.34f, 1);
        W.transform.position = tempW;

        Vector3 tempA = new Vector3(player.transform.position.x - 7.16f, player.transform.position.y - 2.3f, 1);
        A.transform.position = tempA;


        
        Vector3 tempD = new Vector3(player.transform.position.x - 4.35995f, player.transform.position.y - 2.34f, 1);
        D.transform.position = tempD;
    }
}

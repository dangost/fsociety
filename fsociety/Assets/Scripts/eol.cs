using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eol : MonoBehaviour
{
    public GameObject player;
    bool LevelEnded = false;
    int i = 0;
    private void FixedUpdate()
    {
        if(i == 300)
        {
            SceneManager.LoadScene(0+1);
        }
        if(LevelEnded)
        {
            i++;
        }
        if(player.transform.position.x >= 5.74f && player.transform.position.x <= 9.46f && player.transform.position.y >= 2.40f && player.transform.position.y <= 4f)
        {
            LevelEnded = true;
        }
    }
}

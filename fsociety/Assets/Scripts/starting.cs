using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class starting : MonoBehaviour
{
    int i = 0;
    private void FixedUpdate()
    {
        i++;
        if(i == 150)
        SceneManager.LoadScene(1);
    }
}

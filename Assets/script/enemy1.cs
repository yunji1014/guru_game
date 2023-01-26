using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene(3);
    }
}

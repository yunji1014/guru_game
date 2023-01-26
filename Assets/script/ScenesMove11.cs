using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesMove11 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Player");

        if (other.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}

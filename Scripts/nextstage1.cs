using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextstage1 : MonoBehaviour
{
    // Start is called before the first frame update
    void  OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("next");
        SceneManager.LoadScene(3);
    }
}

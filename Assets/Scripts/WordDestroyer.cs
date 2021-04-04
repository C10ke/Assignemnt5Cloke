using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject, 2);
        SceneManager.LoadScene("End");


    }
}

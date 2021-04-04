using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed = .80f;

    //add slider to adjust fallspeed

    //add function to change fallspeed

    private void Start()
    {
        fallSpeed = PlayerPrefs.GetFloat("NEWFALLSPEED", 1);
    }
    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }

    public void WordSpeed(float newSpeed)
    {
        fallSpeed = newSpeed;
        PlayerPrefs.SetFloat("NEWFALLSPEED", fallSpeed);
    }

    public void SetWord (string word)
    {
        text.text = word;
    }

    public void RemoveLetter ()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    

    public void RemoveWord()
    {
        Destroy(gameObject);

        //add to score when word is removed.
    }
    
    

}

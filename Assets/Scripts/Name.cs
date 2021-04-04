using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Name : MonoBehaviour
{
    public string playerName;
    public GameObject inputField;
    public GameObject textDisplay;
    public Text DisplayPlayerName;


    public void StoreName()
    {
        playerName = inputField.GetComponent<Text>().text;
        PlayerPrefs.SetString("PLAYERNAME", playerName);
        textDisplay.GetComponent<Text>().text = "こんにちは\n(Konnichiwa)\n" + playerName + "-san。";


    }

    void Start()
    {
        DisplayPlayerName.text = PlayerPrefs.GetString("PLAYERNAME", "Person");
    }
}
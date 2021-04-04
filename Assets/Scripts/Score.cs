using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int letterCount;

    public Text text;
    public Text hightScore;
    public Text gameOverScore;

    void Start()
    {
        letterCount = 0;
        hightScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        gameOverScore.text = PlayerPrefs.GetInt("GAMEOVERSCORE", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = letterCount.ToString();
        PlayerPrefs.SetInt("GAMEOVERSCORE", letterCount);



        if (letterCount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", letterCount);
            hightScore.text = letterCount.ToString();
        }


    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        hightScore.text = "0";

    }

    public void SaveGame()
    {
        Save.SavePlayer(this);

    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        save.letterCount = letterCount;

        
        return save;
    }


    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }

    public void LoadGame()
    {
        
        PlayerData data = Save.LoadPlayer();

        letterCount = data.letterCount;
    }
}
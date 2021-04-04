using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int highScores;
    public int letterCount;
    //pincount

    public PlayerData(Score score)
    {
        letterCount = Score.letterCount;
    }
}

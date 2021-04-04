using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "year toshi","month getsu","day nichi","week shuu","today kyou","tomorrow ashita","yesterday kinou",
        "time jikan","minute bun","time toki","japan nihon","thing mono","college daigaku","now ima","before mae","after ato","train densha",
        "car kuruma","room heya","name namae","subway chikatetsu","school gakkou","english eigo","japanese nihongo","language gengo",
        "words tango","water mizu","movie eiga","tv terebi","family kazoku","town machi","bathroom toire","home uchi",
        "far tooi","near chikai","small chiisai","big ookii","bad warui","difficult muzukashii","delicious oishii","amazing sugoi","very totemo",
        "go iku","this kore","that sore","job shigoto","buy kau","now ima","new atarashii","child kodomo","student gakusei        "};

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}

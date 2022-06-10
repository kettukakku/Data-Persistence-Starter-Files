using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveManager:MonoBehaviour
{
    private static SaveManager _instance;

    public static SaveManager Instance { get { return _instance; } }

    public ScoreScriptableObject savedScore;
    
    public string nameText;
    public int score;

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        if(_instance != null && _instance == this)
        {
            Debug.Log("Instantiating!");
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SaveHighScore(string name, int score)
    {
        if (score >= savedScore.score)
        {
            savedScore.score = score;
            savedScore.nameText = name;
        }
    }

    public bool HasHighScore()
    {
        if (savedScore.score > 0)
        {
            return true;
        }
        return false;
    }


}

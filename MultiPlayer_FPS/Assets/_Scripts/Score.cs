using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text HS;

    
    public static int scoretxt;
    // Start is called before the first frame update
    void Awake(){
        HS.text=PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoretxt.ToString();
        int.TryParse(scoreText.text,out scoretxt);
        SaveHighScore(scoretxt);
    }
    private bool SaveHighScore(int newScore)
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        bool gotNewHighScore = newScore > highScore;

        if (gotNewHighScore)
        {
            PlayerPrefs.SetInt("HighScore", newScore);
            PlayerPrefs.Save();
        }

        return gotNewHighScore;
    }
}

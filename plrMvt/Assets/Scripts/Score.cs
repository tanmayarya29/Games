using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text HS;

    //gmovr
    public Text goscoreText;
    public Text goHS;
    int scoretxt;
    // Start is called before the first frame update
    void Awake(){
        HS.text=PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text=player.position.z.ToString("0");
        goscoreText.text="S C O R E : "+ scoreText.text;
        goHS.text="H I G H    S C O R E : "+HS.text;

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

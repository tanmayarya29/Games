using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hsd : MonoBehaviour
{
    public Text hs;

    private void Start()
    {
    hs.text="High Score : "+PlayerPrefs.GetInt("HighScore", 0).ToString();

    }
}

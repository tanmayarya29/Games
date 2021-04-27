using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public static float minutes = 5f;
    private float timeStart = 60f*timer.minutes;
    public Text textBox;

	// Use this for initialization
	void Start () {
        textBox.text = timeStart.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        timeStart -= Time.deltaTime;
        
        if (timeStart > 0)
        {
            // counter= Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        }
        else
        {
            SceneManager.LoadScene("End");
        }
	}
    ////////////
}

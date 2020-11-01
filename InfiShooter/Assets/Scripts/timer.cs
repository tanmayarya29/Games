using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{   
    public float timeStart = 60;
    public Text textBox;
    public GameObject got;

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
            got.SetActive(true);
            plrMvt.Tover=true;
        }
	}
    ////////////
}

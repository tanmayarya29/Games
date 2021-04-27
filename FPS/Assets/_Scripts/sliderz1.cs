using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderz1 : MonoBehaviour
{
    private Image healthBar; 
    public targetEnemy te;
    // Start is called before the first frame update
    void Start()
    {
        healthBar=GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount=(te.health)/20;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderz : MonoBehaviour
{
    private Image healthBar; 
    public TargetPlayer tp;
    // Start is called before the first frame update
    void Start()
    {
        healthBar=GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount=(tp.health)/100;
    }
}

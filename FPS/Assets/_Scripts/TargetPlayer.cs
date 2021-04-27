using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetPlayer : MonoBehaviour
{
    public float health = 100f;
    public float gv = 1f;

    public void takeDmg(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("End");
        }
    }

    void gainHealth(float gv)
    {
        if (health < 100)
        {
            health += gv;
        }
    }

    float timer;

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
         if(timer>1)
        {
            gainHealth(gv);
            timer = 0;
        }
    }
}

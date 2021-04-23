using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    static int final_score;
    public int scorepoint;
    private float timer=0.0f;
    void Update()
    {
        if (timer < 1)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            scorepoint++;
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            if (SceneManager.GetActiveScene().buildIndex==1)
            {
                final_score = scorepoint;
            }
            timer = 0;
        }
        scoreUI.text = "Score: " + final_score.ToString(); 
    }
}

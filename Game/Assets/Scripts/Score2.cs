using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public GameObject Ball;
    // Update is called once per frame
    void Update()
    {
        scoreUI.text = "Lives:" + Ball.GetComponent<Ball>().life.ToString();
    }
}

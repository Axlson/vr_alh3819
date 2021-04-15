using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    public AudioSource score_increment;
    public AudioSource lost;
    public AudioSource win;
    private int score = 0;
    private TextMesh tm;
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementScore()
    {
        score++;
        if (score >= 11)
        {
            tm.text = "Win!";
            tm.color = Color.green;
            win.Play();
        } else
        {
            tm.text = "Score: " + score;
            score_increment.Play();
        }
        
    }

    public void displayLost()
    {
        tm.text = "Lost!";
        tm.color = Color.red;
        lost.Play();
    }
}

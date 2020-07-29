using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public Text scoreText;
    private int score;

    void IncreaseScore()
    {
        score++;

        scoreText.text = "score : " + score;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            IncreaseScore();
        }
    }
}

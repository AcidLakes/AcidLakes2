using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    // text mesh pro library

public class GameController : MonoBehaviour
{
    //== private fields ==
    private float timer;
    private float score = 0;
    [SerializeField] private TextMeshProUGUI ScoreText;

    // == private methods ==
    private void Awake()
    {
        //SetupSingleton();
    }
    private void Start()
    {
        score = 0;
        UpdateScore();
    }
    void Update()
    {
        UpdateScore();
        
    }
    private void UpdateScore()
    {
        // display on screen
        timer += Time.deltaTime;

        if (timer > 0f)
        {

            score += 0.25f;
            //Debug.Log("Score (debug): " + score);

            if (score % 10 == 0)
            {
                //score = score / 4;
                Debug.Log("Score: " + score/10);
                float edittedScore = score / 10;
                ScoreText.text = edittedScore.ToString();
            }
            //We only need to update the text if the score changed.
            //scoreText.text = score.ToString();

            //Reset the timer to 0.
            //timer = 0;
        }
    }
}

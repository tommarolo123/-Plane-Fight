using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public Text scoreText;
    public Text gameOverText;

    int playScore = 0;

    public void AddScore()
    {
        playScore++;
        scoreText.text = playScore.ToString();
        //intスコア数をTextに反映する
        
    }
    public void PlayerDied()
    {
        gameOverText.enabled = true;
        
        Time.timeScale = 0;//止まる
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject cloud;
    public GameObject coin;
    private int score;
    private int lives;
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        CreateSky();
        InvokeRepeating("CreateCoin", 2f, 4f);
        score = 0;
        lives = 3;
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 7.5f, 0), Quaternion.identity);
    }

    void CreateSky()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(cloud, transform.position, Quaternion.identity);
        }
    }

    void CreateCoin()
    {
        Instantiate(coin, new Vector3(Random.Range(-10f, 10f), Random.Range(-6f, 6f), 0), Quaternion.identity);
    }

    public void EarnScore(int howMuch) 
    {  
        score = score + howMuch;
        scoreText.text = "Score: " + score;
    }

    public void LivesLeft() 
    {  
        lives = lives - 1; 
        livesText.text = "Lives: " + lives;
    }
}

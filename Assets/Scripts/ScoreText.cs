using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public GameManager gameManager;
    private int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score = gameManager.Score;
        scoreText.text = "Score: " + Score;
    }
}

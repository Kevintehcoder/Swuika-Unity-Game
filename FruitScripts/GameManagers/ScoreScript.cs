using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

    public static ScoreScript instance;
    public static Scores ScoreData = new();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        CheckScore();
    }

    public void IncreaseScore(int Addition)
    {
        ScoreData.Score += Addition;
    }

    public void CheckScore()
    {
        if (ScoreData.HighestScore < ScoreData.Score)
        {
            ScoreData.HighestScore = ScoreData.Score;
        }
        
    }
}

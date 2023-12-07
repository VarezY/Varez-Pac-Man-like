using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _scoreText;

    private int _score;
    private int _maxScore;
    private int _heatlh;

    private void Start()
    {
        UpdateUI();
    }
    
    public void AddScore(int value)
    {
        _score += value;
        UpdateUI();
    }

    public void UpdateUI()
    {
        _scoreText.text = "Score: " + _score + " / " + _maxScore;
    }

    public void SetMaxScore(int count)
    {
        _maxScore = count;
        UpdateUI();
    }
}

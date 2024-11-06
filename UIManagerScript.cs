using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    [SerializeField]
    private int _score = 0;
    void Start()
    {
        _scoreText.text = "Score: " + _score;   
    }

    public void AddScore(int _killPoint)
    {
        _score += _killPoint;
        _scoreText.text = "Score: " + _score.ToString();
    }
}

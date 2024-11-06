using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public Text _scoreText; // We will assign this dynamically
    private int _score = 0;

    void Start()
    {
        // Fetch the ScoreText GameObject and retrieve the Text component
        GameObject scoreTextObject = GameObject.Find("ScoreText");

        if (scoreTextObject != null)
        {
            Debug.Log("ScoreText GameObject found.");

            // Attempt to retrieve the Text component
            _scoreText = scoreTextObject.GetComponent<Text>();

            if (_scoreText == null)
            {
                Debug.LogError("No Text component found on the ScoreText GameObject.");
            }
            else
            {
                Debug.Log("Text component successfully assigned.");
            }
        }
        else
        {
            Debug.LogError("ScoreText GameObject not found.");
        }
    }

    public void AddScore(int _killPoint)
    {
        _score += _killPoint;

        if (_scoreText != null)
        {
            _scoreText.text = "Score: " + _score.ToString();
            Debug.Log("Score updated to: " + _score);
        }
        else
        {
            Debug.LogError("Cannot update score because _scoreText is NULL!");
        }
    }
}

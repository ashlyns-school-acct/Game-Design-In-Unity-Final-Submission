using UnityEngine;
using TMPro;

public class VariableHolder : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject winText;
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        winText = GameObject.Find("WinTextHolder");
        winText.SetActive(false);
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void Win()
    {
        winText.SetActive(true);
    }
}

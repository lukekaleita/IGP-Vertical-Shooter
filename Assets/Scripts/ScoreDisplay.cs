using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text text;

    private void OnEnable()
    {
        ScoreManager.scoreChanged += OnScoreChanged;
        OnScoreChanged(ScoreManager.Score);
    }

    private void OnDisable()
    {
        ScoreManager.scoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int obj)
    {
        text.text = ScoreManager.Score.ToString();
    }
}
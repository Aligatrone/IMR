using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private GameController gameController;

    public void UpdateScore()
    {
        scoreText.text = "Score:" + gameController.score.ToString();
    }
}

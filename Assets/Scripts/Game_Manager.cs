using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    private int score;

    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    public void IncreaseScore()
    {
        score++;
    }
}

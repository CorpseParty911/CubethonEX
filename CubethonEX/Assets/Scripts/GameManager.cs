using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    public float resetDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().enabled = false;
    }

    public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Debug.Log("Game Over.");
            Invoke("Restart", resetDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

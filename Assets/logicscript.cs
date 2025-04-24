using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject GameOverscreen;

    [ContextMenu("Increase score")]
    public void addscore(int scoree)
    {
        score += scoree;
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        GameOverscreen.SetActive(true);
    }
}

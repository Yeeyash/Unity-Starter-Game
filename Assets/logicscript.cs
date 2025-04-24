using UnityEngine;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int score;
    public Text scoreText;

    [ContextMenu("Increase score")]
    public void addscore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}

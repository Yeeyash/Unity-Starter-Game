using UnityEngine;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int score;
    public Text scoreText;

    [ContextMenu("Increase score")]
    public void addscore(int scoree)
    {
        score += scoree;
        scoreText.text = score.ToString();
    }
}

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Game: MonoBehaviour
{
    public Text scoreText;
    public static int score;
    public void Update()
    {
        if(scoreText!=null)
        scoreText.text = score + "";

    }
}

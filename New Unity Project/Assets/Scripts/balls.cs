using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class balls : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public Text scoreText;
    public static int score;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        InvokeRepeating("Destroy", 1.4f, 1);
    }
    public void FixedUpdate()
    {
        transform.localScale += new Vector3(0.2f, 0.2f, 0);
        rb.velocity = new Vector2(0, -speed);
        if (scoreText != null)
            scoreText.text = score.ToString();
    }
    void OnMouseDown()
    {
        score++;
        Destroy(this.gameObject);
    }
    void Destroy()
    {
        Destroy(this.gameObject);
        score--;
    }
  }


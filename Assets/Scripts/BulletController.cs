using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public int scoreValue = 10;

    private void FixedUpdate()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        Vector2 movement = Vector2.up * speed;
        GetComponent<Rigidbody2D>().velocity = movement;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyShip"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            ScoreText scoreText = FindObjectOfType<ScoreText>();
            if (scoreText != null)
            {
                scoreText.AddScore(scoreValue);
            }
        }
    }
}


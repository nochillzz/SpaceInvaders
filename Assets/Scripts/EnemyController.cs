using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 2f;
    private float startingX;
    private bool moveRight = true;

    private void Start()
    {
        startingX = transform.position.x;
    }

    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        float targetX = moveRight ? startingX + moveDistance : startingX - moveDistance;
        float step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(targetX, transform.position.y), step);

        if (transform.position.x == targetX)
        {
            moveRight = !moveRight;
        }
    }
}


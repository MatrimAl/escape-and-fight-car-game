using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerEnemy : MonoBehaviour
{
    public GameObject rocketPrefab;
    public float rocketRespawnTime = 5.0f;
    public float speedY = 7.0f;
    public float speedX = 7.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speedX, speedY);
        StartCoroutine(rocketShoot());

    }

    void Update()
    {
        Move();
    }

    private void spawnRocket()
    {
        GameObject a = Instantiate(rocketPrefab) as GameObject;
        a.transform.position = new Vector2(transform.position.x, transform.position.y);
    }


    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }




    }

    void Move()
    {
        if (transform.position.y > -22)
        {
            
            if (transform.position.x > 16)
            {
                rb.velocity = new Vector2(-speedX, 0);
            }
            else if (transform.position.x < -17)
            {
                rb.velocity = new Vector2(speedX, 0);
            }



        }
    }

    IEnumerator rocketShoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(rocketRespawnTime);
            spawnRocket();
        }
    }

}



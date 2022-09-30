using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        
    }
    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }

    }
        void Update()
    {
        if (transform.position.y < -42 )
        {
         
            Destroy(this.gameObject);
        }
    }
}

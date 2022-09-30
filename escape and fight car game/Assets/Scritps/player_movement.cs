using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float moveSpeed = 25;

    




    void Start()
    {
       
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D peel)
    {
        if (peel.tag == "peel")
        {
            StartCoroutine(Peel());
            moveSpeed -= 17;
            Destroy(peel.gameObject);
            IEnumerator Peel()
            {
                yield return new WaitForSeconds(5);
                moveSpeed += 17;
            }

        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb2d.velocity += new Vector2(moveSpeed, 0);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb2d.velocity -= new Vector2(moveSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            rb2d.velocity += new Vector2(-moveSpeed, 0);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb2d.velocity -= new Vector2(-moveSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb2d.velocity += new Vector2(0, moveSpeed);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb2d.velocity -= new Vector2(0, moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb2d.velocity += new Vector2(0, -moveSpeed);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb2d.velocity -= new Vector2(0, -moveSpeed);
        }
        if (!(Input.GetKey(KeyCode.DownArrow) ||
           (Input.GetKey(KeyCode.RightArrow)) ||
           (Input.GetKey(KeyCode.LeftArrow)) ||
           (Input.GetKey(KeyCode.UpArrow))))
        {
            rb2d.velocity = new Vector2(0, 0);
        }
    }
    
}

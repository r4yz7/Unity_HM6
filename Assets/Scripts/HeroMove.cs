using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{   Rigidbody2D rigidbody2;
    SpriteRenderer spriteRenderer;
    Animator animator;
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float right = Input.GetAxis("Horizontal");
        if (right != 0)
        {
            var pos = transform.position;
            pos += Vector3.right * right * Time.deltaTime * 60;
            rigidbody2.MovePosition(pos);
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        if (right < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (right > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
}

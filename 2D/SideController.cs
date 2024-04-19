//code type : 2D
//code version : 1.1
//last working : unity2022.3.17f

using UnityEngine;

public class SideController : MonoBehaviour
{
    public float movement_speed = 7.5f;
    public float jump_power = 17.5f;
    public bool IsGround = true;

    private float moveX;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * movement_speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && IsGround)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump_power), ForceMode2D.Impulse);
            IsGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.CompareTag("Floor") || target.gameObject.CompareTag("Box"))
        {
            IsGround = true;
        }
        /*else if (target.gameObject.CompareTag("") && !isReloading)
        {

        }*/
    }
        /* private void OnCollisionExit2D(Collision2D target)
    {
        if (target.gameObject.CompareTag(""))
        {
        }
        else if (target.gameObject.CompareTag(""))
        {
        }

    } */

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Trampoline"))
        {
            IsGround = true;
            jump_power = jump_power*5;
        }
        /* else if (target.gameObject.CompareTag(""))
        {
        } */

    } 

    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Trampoline"))
        {
            IsGround = true;
            jump_power = jump_power/5;
        }
    }
}

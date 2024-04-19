//code type : 2D
//code version : 1.1
//last working : unity2022.3.17f

using UnityEngine;

public class TopController : MonoBehaviour
{
    public float movement_speed = 7.5f;
    public bool instant_move = true;

    private float moveX;
    private float moveY;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        if (instant_move)
        {
            moveX = Input.GetAxisRaw("Horizontal");
            moveY = Input.GetAxisRaw("Vertical");
        } else{
            moveX = Input.GetAxis("Horizontal");
            moveY = Input.GetAxis("Vertical");
        }

        rb.velocity = new Vector2(moveX * movement_speed, moveY * movement_speed);
    
    }

    /* private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.CompareTag(""))
        {
        }
        else if (target.gameObject.CompareTag(""))
        {
        }
    } */
    /* private void OnCollisionExit2D(Collision2D target)
    {
        if (target.gameObject.CompareTag(""))
        {
        }
        else if (target.gameObject.CompareTag(""))
        {
        }

    } */

    /* private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag(""))
        {
        }
        else if (target.gameObject.CompareTag(""))
        {
        }
    }  */

    /* private void OnTriggerExit2D(Collider2D target)
    {
        if (target.gameObject.CompareTag(""))
        {
        }
        else if (target.gameObject.CompareTag(""))
        {
        }
    } */
}

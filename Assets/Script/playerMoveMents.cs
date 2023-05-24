using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMoveMents : MonoBehaviour
{
    public float speed;

    public Animator animator;

    private Vector3 direction;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        direction = new Vector3(horizontal, vertical);

        AnimatorMovement(direction);
        
    }

    private void FixedUpdate()
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }

    void AnimatorMovement(Vector3 direction)
    {
        if(animator != null)
        {
            if(direction.magnitude > 0) 
            {
                animator.SetBool("isMoving", true);

                animator.SetFloat("horizontal", direction.x);
                animator.SetFloat("vertical", direction.y);
            }
            else
            {
                animator.SetBool("isMoving", false);
            }
        }
    }
}

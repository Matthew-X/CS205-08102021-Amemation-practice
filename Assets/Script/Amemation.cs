using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amemation : MonoBehaviour
{
    public Animator anim;
    public float Velocity = 0;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("IsWalking", true);
            if (transform.rotation.y != 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                anim.SetBool("IsRunning", true);
            }else
            {
                anim.SetBool("IsRunning", false);
            }
        }else
        {
            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("IsWalking", true);
                if (transform.rotation.y != 90)
                {
                    y = (y + 90) / 2;
                    transform.rotation = Quaternion.Euler(0, y, 0);
                }
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    anim.SetBool("IsRunning", true);
                }
                else
                {
                    anim.SetBool("IsRunning", false);
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("IsWalking", true);
                    if (transform.rotation.y != -90)
                    {
                        transform.rotation = Quaternion.Euler(0, -90, 0);
                    }
                    if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                    {
                        anim.SetBool("IsRunning", true);
                    }
                    else
                    {
                        anim.SetBool("IsRunning", false);
                    }
                }
                else
                {
                    if (Input.GetKey(KeyCode.S))
                    {
                        anim.SetBool("IsWalking", true);
                        if (transform.rotation.y != -180)
                        {
                            transform.rotation = Quaternion.Euler(0, -180, 0);
                        }
                        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                        {
                            anim.SetBool("IsRunning", true);
                        }
                        else
                        {
                            anim.SetBool("IsRunning", false);
                        }
                    }
                    else
                    {
                        anim.SetBool("IsWalking", false);
                    }
                }
            }
        }*/

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("IsWalking", true);
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                transform.forward = Vector3.RotateTowards(transform.forward, Vector3.forward + Vector3.left, 4 * Time.deltaTime, 0);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                transform.forward = Vector3.RotateTowards(transform.forward, Vector3.forward + Vector3.right, 4 * Time.deltaTime, 0);
            }else if (Input.GetKey(KeyCode.W))
            {
                transform.forward = Vector3.RotateTowards(transform.forward,Vector3.forward, 4 * Time.deltaTime,0);
            }
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                anim.SetBool("IsRunning", true);
            }
            else
            {
                anim.SetBool("IsRunning", false);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("IsWalking", true);
                if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
                {
                    transform.forward = Vector3.RotateTowards(transform.forward, Vector3.back + Vector3.left, 4 * Time.deltaTime, 0);
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    transform.forward = Vector3.RotateTowards(transform.forward, Vector3.left, 4 * Time.deltaTime, 0);
                }
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    anim.SetBool("IsRunning", true);
                }
                else
                {
                    anim.SetBool("IsRunning", false);
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("IsWalking", true);
                    if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
                    {
                        transform.forward = Vector3.RotateTowards(transform.forward, Vector3.back + Vector3.right, 4 * Time.deltaTime, 0);
                    }
                    else if (Input.GetKey(KeyCode.D))
                    {
                        transform.forward = Vector3.RotateTowards(transform.forward, Vector3.right, 4 * Time.deltaTime, 0);
                    }
                    if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                    {
                        anim.SetBool("IsRunning", true);
                    }
                    else
                    {
                        anim.SetBool("IsRunning", false);
                    }
                }
                else
                {
                    if (Input.GetKey(KeyCode.S))
                    {
                        anim.SetBool("IsWalking", true);
                        if (transform.rotation.y != -180)
                        {
                            transform.forward = Vector3.RotateTowards(transform.forward, Vector3.back, 4 * Time.deltaTime, 0);
                        }
                        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                        {
                            anim.SetBool("IsRunning", true);
                        }
                        else
                        {
                            anim.SetBool("IsRunning", false);
                        }
                    }
                    else
                    {
                        anim.SetBool("IsWalking", false);
                    }
                }
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("IsJumping", true);
        }
        else
        {
            anim.SetBool("IsJumping", false);
        }
    }
}

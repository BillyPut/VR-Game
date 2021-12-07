using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public GameObject player;
    public float timeRemaining = 5;
    public int state = 0;
    private Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 0)
        {
            Idle();
        }
        if (state == 1)
        {
            Walk();
        }
        
        if (timeRemaining > -5.1)
        {
            timeRemaining -= Time.deltaTime;
        }

        if (timeRemaining < 0.1)
        {
            state = 1;
        }
     
        if (timeRemaining < -4.9)
        {
            state = 0;
            timeRemaining = 5;
        }






    }

    void Idle()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = 0;
        Helper.SetVelocity(velocity.x, 0, gameObject);
    }

    void Walk()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = 0.5f;
        Helper.SetVelocity(velocity.x, 0, gameObject);
    }




}

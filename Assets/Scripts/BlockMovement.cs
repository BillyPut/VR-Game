using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public GameObject player;
    public float timeRemaining = 5;
    public float enemySpeed;
    public int state = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Idle()
    {
        timeRemaining = timeRemaining - Time.deltatime
    }






}

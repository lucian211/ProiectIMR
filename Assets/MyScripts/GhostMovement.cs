using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{

    float low;
    float hight; 
    float target;
    float speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        hight = transform.localPosition.y + 0.1f;
        low = transform.localPosition.y - 0.1f;
        target = hight;

      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(transform.localPosition.x, target, transform.localPosition.z), speed *0.1f* Time.deltaTime);
       
        if (transform.localPosition.y >= hight)
       {   low = transform.localPosition.y - 0.2f;
            target = low;
          
        }
        if (transform.localPosition.y <= low)
        {
            hight = transform.localPosition.y +0.2f;
            target = hight;
        }


    }
}


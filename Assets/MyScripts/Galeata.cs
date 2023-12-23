using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galeata : MonoBehaviour
{  Vector3 startPosition;
   private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position!=startPosition)
        {
            animator.CrossFade("toarta", 0.01f);
        }
    }
}

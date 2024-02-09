using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limax : MonoBehaviour
{
    private Animator animator;
    bool d = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "stick")
        {  
            transform.SetParent(colliderInfo.gameObject.transform);
            animator.CrossFade("hit", 0.01f);
            if (d == false)
            {
                GameObject player = GameObject.Find("Player");
                PlayerController control = player.GetComponent<PlayerController>();
                control.killLimax();
                d = true;
            }


        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "teren")
        {
            transform.SetParent(null);
        }
    }
}
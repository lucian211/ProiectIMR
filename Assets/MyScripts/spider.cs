using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider : MonoBehaviour
{
    public Transform ancor;
    private Animator animator;
    bool dea = false;
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
        if (colliderInfo.tag == "ice"&&dea!=true)
        {
            dea = true;
           // colliderInfo.gameObject.transform.parent = ancor;
            animator.CrossFade("d", 0.01f);
            GameObject player = GameObject.Find("Player");
            PlayerController control = player.GetComponent<PlayerController>();
            control.killSpike();

            //   Debug.Log("A nimerit");
        }
    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlController : MonoBehaviour
{   public Transform player;

    float distanceToPlayer = 1000.0f;

    [SerializeField]
    GameObject sunet1;
    private GameObject sunet1_inst;
    bool s1 = false;
    bool count1=false;
    float time1=3.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (count1==true)
        {
            time1 = time1 - Time.deltaTime;
            if (time1<=0)
            {
                count1 = false;

                GameObject player = GameObject.Find("Player");
                PlayerController control = player.GetComponent<PlayerController>();
                control.ReceiveSound1();


                Destroy(sunet1_inst.gameObject);
            }
              

        }
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer < 5 && s1 == false)
        {
            s1 = true;
            sunet1_inst = Instantiate(sunet1);
            sunet1_inst.transform.position = transform.position;
            count1 = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   bool r1 = false;

    [SerializeField]
    GameObject sunet1;
    private GameObject sunet1_inst;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(r1==true)
        {
            sunet1_inst = Instantiate(sunet1);
            sunet1_inst.transform.position = transform.position;
            r1 = false;
        }
    }

    public void ReceiveSound1()
    {
        r1 = true;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScene2 : MonoBehaviour
{
    bool height = false;
    public CharacterController CC;
    [SerializeField]
    GameObject sunet1;
    GameObject sunet1_inst;
    // Start is called before the first frame update
    void Start()
    {
        CC = GetComponent<CharacterController>();
        CC.height = 2;
        sunet1_inst = Instantiate(sunet1);
        sunet1_inst.transform.position = transform.position;
        sunet1_inst.transform.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (height == false)
        {
            height = true;
            CC.height = 2;
        }
    }

}

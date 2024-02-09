using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class PlayerController : MonoBehaviour
{
    bool r1 = false;
    public CharacterController CC;
    [SerializeField]
    GameObject sunet1;
    [SerializeField]
    GameObject sunet2;
    [SerializeField]
    GameObject sunet3;
    [SerializeField]
    GameObject sunet4;
    [SerializeField]
    GameObject sunet5;
    [SerializeField]
    GameObject sunet6;
    [SerializeField]
    GameObject sunet7;
    [SerializeField]
    GameObject sunet8;
    [SerializeField]
    GameObject sunet9;
    [SerializeField]
    GameObject sunet10;
    private GameObject sunet1_inst;
    private GameObject sunet2_inst;
    private GameObject sunet3_inst;
    private GameObject sunet4_inst;
    private GameObject sunet5_inst;
    private GameObject sunet6_inst;
    private GameObject sunet7_inst;
    private GameObject sunet8_inst;
    private GameObject sunet9_inst;
    private GameObject sunet10_inst;

    bool height = false;
    int dialog = 0;
    float t1 = 3.0f;
    int limax = 0;
    int spike = 0;
    bool second = true;
    public Transform spider;
    bool wall = false;
    bool to8 = false;
    bool to3 = false;
    bool to4 = false;
    public Transform stopper;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    // Start is called before the first frame update
    void Start()
    {
        CC = GetComponent<CharacterController>();
        CC.height = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (height == false)
        {
            height = true;
            CC.height = 2;
        }


        // if (r1==true)
        //  {
        //     sunet1_inst = Instantiate(sunet1);
        //    sunet1_inst.transform.position = transform.position;
        //    r1 = false;
        // }


        if (dialog == 0)
        {
            t1 = t1 - Time.deltaTime;
            if (t1 <= 0)
            {
                dialog = 1;
                sunet1_inst = Instantiate(sunet1);
                sunet1_inst.transform.position = transform.position;
                sunet1_inst.transform.parent = this.transform;
                t1 = 30.0f;
                text1.SetActive(true);
            }
        }
        if (dialog == 1)
        {
            t1 = t1 - Time.deltaTime;
            if (t1 <= 0)
            {
                dialog = 2;
                sunet2_inst = Instantiate(sunet2);
                sunet2_inst.transform.position = transform.position;
                sunet2_inst.transform.parent = this.transform;
                t1 = 25.0f;
                text1.SetActive(false);
            }
        }

        if(dialog==2&&to3==false)
        {
            t1 = t1 - Time.deltaTime;
           
              if (t1 <= 0)
            {
                to3 = true;
                t1 = 25.0f;
            }
        }


        if (dialog == 2 &&to3==true&& limax == 3)
        {
            dialog = 3;
           
            sunet3_inst = Instantiate(sunet3);
            sunet3_inst.transform.position = transform.position;
            sunet3_inst.transform.parent = this.transform;
           
        }

        if (dialog == 3 && to4 == false)
        {
            t1 = t1 - Time.deltaTime;
            if (t1 < 10 &&second==true)
            { text2.SetActive(true);
                second = false;
            }

            if (t1 <= 0)
            {
                to4 = true;
                t1 = 15.0f;
            }

        }


        if (dialog == 3 && to4 == true)
        {  
            float distanceToSpider = Vector3.Distance(transform.position, spider.position);

            if (distanceToSpider < 10)
            {
                text2.SetActive(false);
                dialog = 4;
                sunet4_inst = Instantiate(sunet4);
                sunet4_inst.transform.position = transform.position;

            }
        }


        if (dialog == 4)
        {
            t1 = t1 - Time.deltaTime;
            if (t1 <= 0)
            {
                to4 = true;
                dialog = 5;
                sunet5_inst = Instantiate(sunet5);
                sunet5_inst.transform.position = transform.position;
                t1 = 10.0f;
            }

        }
        if (dialog == 5)
        {
            t1 = t1 - Time.deltaTime;
            if (t1 <= 0)
            {
                text2.SetActive(false);
                to4 = true;
                dialog = 6;
                sunet6_inst = Instantiate(sunet6);
                sunet6_inst.transform.position = transform.position;
                t1 = 10.0f;
                stopper.position = new Vector3(1, 1, 1);
                text3.SetActive(true);
            }

        }

        if (spike == 1&&dialog==6)
        {
            text3.SetActive(false);
            text4.SetActive(true);
            dialog = 7;
            sunet7_inst = Instantiate(sunet7);
            sunet7_inst.transform.position = transform.position;
            spike = 0;
        }

        if (dialog == 7&&to8==false)
        {
            t1 = t1 - Time.deltaTime;
            if (t1 <= 0)
            {
                to8 = true;
                t1 = 15;
            }
        }

        if(to8==true&&wall==true)
        {
            text4.SetActive(false);
            dialog = 8;
            to8 = false;
            sunet8_inst = Instantiate(sunet8);
            sunet8_inst.transform.position = transform.position;
        }
    }

    public void ReceiveSound1()
    {
        r1 = true;

    }
    public void killLimax()
    {
        limax = limax + 1;

    }
    public void killSpike()
    {
        spike = spike + 1;
        stopper.position = new Vector3(0,0,0);
    }

    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "wall")
        { wall = true; }
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{
    [SerializeField]
    private ActionBasedController Controller = null;

   
    private Animator animator;
    private bool isOpen = true;
    [SerializeField]
    GameObject proiectil;
    GameObject proiectil_inst;
    public Transform place;
    public Transform stopper;
    float time1 = 2.0f;
    bool b1 = false;
    bool canShot = false;
    // Start is called before the first frame update
    void Start()
    {
        
        animator = GetComponent<Animator>();
       
     }


    private void FixedUpdate()
    {
        if(b1==true)
        {
            time1 = time1 - Time.deltaTime;
            if(time1<=0)
            {
                b1 = false;
                time1 = 2.0f;
            }

        }
    }
    private void Update()
    {
        if(Controller.selectAction.action.ReadValue<float>()!=0&&isOpen==true)
        {
            animator.CrossFade("grab", 0.01f);
            isOpen = false;
        }
        if (Controller.selectAction.action.ReadValue<float>() == 0 && isOpen == false)
        {
            animator.CrossFade("grab_final", 0.01f);
            isOpen = true;
        }

        if (Controller.activateAction.action.ReadValue<float>() != 0 && isOpen == true && b1 == false&&canShot==true)
        {
            animator.CrossFade("trigger", 0.01f);
            proiectil_inst = Instantiate(proiectil);
            proiectil_inst.transform.position = place.position;
            proiectil_inst.transform.rotation = transform.parent.gameObject.transform.rotation;
            proiectil_inst.transform.parent = this.transform.parent.gameObject.transform;
            b1 = true;
        }

        if(stopper.position.x==0)
        {
            ShotStop();
        }
        if(stopper.position.x==1)
        {
            ShotApr();
        }
    }

    public void ShotApr()
    {
        canShot = true;
    }
    public void ShotStop()
    {
        canShot = false;
    }

}
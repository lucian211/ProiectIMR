using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice : MonoBehaviour
{

    float count = 7;
    float speed = 0;
    bool ok = true;
    bool ok2 = true;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        //   transform.Translate(Vector3.left * 20 * Time.deltaTime);
        if(ok2==true)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (speed > 0)
        { speed = speed + 0.5f; }
        count = count - Time.deltaTime;
        if (count <= 0)
        {
            Destroy(this.gameObject);
        }
        if (count <= 5.0f && speed == 0&&ok==true)
        {
            ok = false;
            speed = speed + 25;
            transform.parent = null;
        }
    }

  //  void OnTriggerEnter(Collider colliderInfo)
   // {
    //    if (colliderInfo.tag == "spider")
    //    {
     //       speed = 0;
     //       ok2 = false;
     //   }
   // }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "teren")
        {
            ok2 = false;
            speed = 0;
        }
    }
}

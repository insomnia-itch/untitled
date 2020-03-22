using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    Animator toggleChest;
    // Start is called before the first frame update
    void Start()
    {
        toggleChest = gameObject.GetComponent<Animator>();
        toggleChest.SetBool("IsClosed", true);
    }

    // Update is called once per frame
    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one

    }


    private void OnTriggerStay2D(Collider2D other)
    {
    //    Debug.Log("entered");
//        Animator toggleChest = other.gameObject.GetComponent<Animator>();
        if (Input.GetKey(KeyCode.Space))
        {
            bool closed = toggleChest.GetBool("IsClosed");
            if (closed)
            {
            toggleChest.ResetTrigger("IsClosed");
            toggleChest.SetTrigger("IsOpen");
            } else
            {
            toggleChest.ResetTrigger("IsOpen");
            toggleChest.SetTrigger("IsClosed");

            }
            //Reset the "Crouch" triggerd
            //Send the message to the Animator to activate the trigger parameter named "Jump"
        }

        if (Input.GetKey("z"))
        {
            //Reset the "Jump" trigger
            toggleChest.ResetTrigger("IsOpen");
            Debug.Log("ez");
            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            toggleChest.SetTrigger("IsClosed");
        }

    }
}

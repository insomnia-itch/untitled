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

    }

    // Update is called once per frame
    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
//        Animator toggleChest = other.gameObject.GetComponent<Animator>();
        if (Input.GetKey(KeyCode.Space))
        {
            //Reset the "Crouch" trigger
            toggleChest.ResetTrigger("IsClosed");

            //Send the message to the Animator to activate the trigger parameter named "Jump"
            toggleChest.SetTrigger("IsOpen");
        }

        if (Input.GetKey("z"))
        {
            //Reset the "Jump" trigger
            toggleChest.ResetTrigger("IsOpen");

            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            toggleChest.SetTrigger("IsClosed");
        }

    }
}

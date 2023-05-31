using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.XR.Interaction.Toolkit;

public class BookTextScript : MonoBehaviour
{
    //field which declares the
    //GameObjects image/text to
    //be used later in the code
    public GameObject image;
    public GameObject text;

    //Declares that Left/RightHand
    //is of type bool: true/false
    //in context of the code
    bool LeftHand;
    bool RightHand;

    // Start is called before the first frame update
    void Start()
    {
        //Activates/deactivates
        //the given GameObjects,
        //depending on the given
        //true/false value
        image.SetActive(false);
        text.SetActive(false);
        LeftHand = false;
        RightHand = false;
    }

    //Explains what the given
    //gameObejct is going to do,
    //when collision happens
    private void OnTriggerEnter(Collider collider )
    {
        //Every value is set to true,
        //so the text script activates
        //when collision happens
        if (collider.gameObject.tag == "LeftHand")
        {
            LeftHand = true;
        }
        else if(collider.gameObject.tag == "RightHand")
        {
            RightHand = true;
        }
        if (RightHand == true || LeftHand == true)
        {
            text.SetActive(true);
            image.SetActive(true);
        }
    }

    //Explains what the given
    //gameObejct is going to do,
    //when collision exits 
    private void OnTriggerExit(Collider collider)
    {
        //Every value is set to false,
        //so the text script deactivates
        //when collision happens
        if (collider.gameObject.tag == "LeftHand")
        {
            LeftHand = false;
        }
        else if (collider.gameObject.tag == "RightHand")
        {
            RightHand = false;
        }
        if(RightHand == false && LeftHand == false)
        {
            text.SetActive(false);
            image.SetActive(false);
        }
    }
}

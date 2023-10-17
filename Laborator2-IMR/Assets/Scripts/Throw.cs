using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Throw : MonoBehaviour
{
    Rigidbody rb;
    public XRGrabInteractable grabInteractable;
    public XRBaseController controller;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}

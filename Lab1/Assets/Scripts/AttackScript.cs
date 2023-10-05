using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2;
    Animator animatorCactus1;
    Animator animatorCactus2;

    void Start()
    {
        animatorCactus1 = cactus1.GetComponent<Animator>();
        animatorCactus2 = cactus2.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(cactus1.transform.position, cactus2.transform.position) < 0.25)
        {
            animatorCactus1.SetBool("Attack", true);
            animatorCactus2.SetBool("Attack", true);
        }
        else
        {
            animatorCactus1.SetBool("Attack", false);
            animatorCactus2.SetBool("Attack", false);
        }
    }
}

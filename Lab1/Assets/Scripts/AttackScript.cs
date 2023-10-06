using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2;
    
    private Animator animatorCactus1;
    private Animator animatorCactus2;
    
    private double minimumDistanceForAttack = 0.25;

    void Start()
    {
        animatorCactus1 = cactus1.GetComponent<Animator>();
        animatorCactus2 = cactus2.GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Vector3.Distance(cactus1.transform.position, cactus2.transform.position) < minimumDistanceForAttack)
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

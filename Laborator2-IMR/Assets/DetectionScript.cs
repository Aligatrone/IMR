using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        /*
        if (collision.gameObject.name == "throwing_dart" || collision.gameObject.name == "throwing_dart2" || collision.gameObject.name == "throwing_dart3" || collision.gameObject.name == "throwing_dart4" || collision.gameObject.name == "throwing_dart5") {
            Debug.Log("Works");
        }
        */

        if (collision.gameObject.name == "Target Board") {
            Debug.Log("SCORE!!! You have hit the target");
        }
        
        
    }
}

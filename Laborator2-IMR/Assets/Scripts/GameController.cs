using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int score;
    public GameObject target;

    public void IncrementScore()
    {
       score += (int) Vector3.Distance(CameraPosition.lastPosition, target.transform.position);
    }
}

using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int score;
    public GameObject player;
    public GameObject target;

    public void IncrementScore()
    {
        score += (int) Vector3.Distance(player.transform.position, target.transform.position);
    }
}

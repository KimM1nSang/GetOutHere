using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janitor : MonoBehaviour
{
    public float viewRange = 10f;
    [Range(0,360)]
    public float viewAngle = 120f;

    public LayerMask layerMask;
    private Transform playerTr;
    private Transform catTr;
    private int playerLayer;
    private int catLayer;

    private void Start()
    {
        //catTr = ;
        playerLayer = LayerMask.NameToLayer("PLAYER");
        catLayer = LayerMask.NameToLayer("CAT");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameManager instance;
    public  GameManager Instance;

    private void Awake()
    {
        if (instance != null)
        {
            
        }
    }
}

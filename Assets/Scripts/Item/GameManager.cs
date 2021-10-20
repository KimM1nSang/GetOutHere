using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform playerTR;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    private void OnDestroy()
    {
        instance = null;
    }

    public static Transform GetPlayer()
    {
        //Debug.Log(instance.playerTR.transform.position);
        return instance.playerTR;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerTR;
    #region 싱글톤
    public static GameManager instance;


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
    #endregion

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

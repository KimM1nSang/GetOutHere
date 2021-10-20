using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
    public static GameManager instance;

    public Transform playerTR;
=======
    #region 싱글톤
    private GameManager instance;
    public  GameManager Instance;
>>>>>>> 5ca1a91e384539e15c420656521a151242e74718

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
<<<<<<< HEAD

    public static Transform GetPlayer()
    {
        //Debug.Log(instance.playerTR.transform.position);
        return instance.playerTR;
    }


=======
    #endregion
>>>>>>> 5ca1a91e384539e15c420656521a151242e74718
}

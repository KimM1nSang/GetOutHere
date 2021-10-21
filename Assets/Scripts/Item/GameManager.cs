using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
    public Transform playerTR;
    #region 싱글톤
    public static GameManager instance;

=======
    #region 싱글톤
    private GameManager instance;
    public GameManager Instance;
>>>>>>> e3b12ec47bf30c2db29a94aff25abd25c98439b8

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
<<<<<<< HEAD

    public static Transform GetPlayer()
    {
        //Debug.Log(instance.playerTR.transform.position);
        return instance.playerTR;
    }


}
=======
    #endregion
}
>>>>>>> e3b12ec47bf30c2db29a94aff25abd25c98439b8

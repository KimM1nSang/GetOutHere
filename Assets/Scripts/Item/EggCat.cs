using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCat : Item
{
    public GameObject Cat;


    public override void UseItem()
    {
        // 고양이 소환
        Instantiate(Cat, transform.position, Quaternion.identity);

        Destroy(this);
    }
}

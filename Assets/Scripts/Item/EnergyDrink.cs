using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDrink : Item
{
    public override void UseItem()
    {
        // 연타해도 hp 여러게 차지 않게 만들어야함
        if (Player.Instance.health < Player.Instance.maxHp)
        {
            Player.Instance.health++;
        }

        Destroy(gameObject);
    }



}

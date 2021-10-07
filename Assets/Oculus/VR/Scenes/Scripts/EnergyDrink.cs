using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDrink : Item
{

    public override void UseItem()
    {
        // 플레이어 hp 1칸 회복 이미 풀피면 아이템만 소모
        // 연타해도 hp 여러게 차지 않게
        if (Player.Instance.health < Player.Instance.maxHp) // 아잉
        {
            Player.Instance.health++;
        }

        // 사용하면 아이템 삭제
        Destroy(this, 0.5f);
    }



}

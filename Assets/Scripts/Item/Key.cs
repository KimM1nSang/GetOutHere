using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Item
{
    public override void UseItem()
    {
        Destroy(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DOOR"))
        {
            collision.gameObject.GetComponent<Door>().isOpen = true;
            UseItem();
        }
    }

}

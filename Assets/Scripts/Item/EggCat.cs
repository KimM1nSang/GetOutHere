using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCat : Item
{
    public GameObject Cat;

    public override void UseItem()
    {
        Instantiate(Cat, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("GROUND"))
        {
            UseItem();
        }
    }
}
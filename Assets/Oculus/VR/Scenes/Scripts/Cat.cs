using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private bool isMove = true;
    public float speed;

    void Update()
    {
        if (isMove)
        {
            transform.Translate(transform.forward * Time.deltaTime * speed);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        isMove = false;
    }
}

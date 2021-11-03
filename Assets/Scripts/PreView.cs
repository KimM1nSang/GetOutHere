using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreView : MonoBehaviour
{    
    public float turnSpeed = 4.0f; // 마우스 회전 속도    
    private float xRotate = 0.0f; 
    public float moveSpeed = 4.0f; // 이동 속도
    
    void Update()
    {
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        float yRotate = transform.eulerAngles.y + yRotateSize;

        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);
    
        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);

        Vector3 move = 
            transform.forward * Input.GetAxis("Vertical") + 
            transform.right * Input.GetAxis("Horizontal");

        transform.position += move * moveSpeed * Time.deltaTime;
    }
}

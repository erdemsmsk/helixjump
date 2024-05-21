using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rptatemove : MonoBehaviour
{
    public float rotatespedd;
    private float moveX;  
   
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButtonDown(0)) {
            transform.Rotate(0f, moveX * rotatespedd * Time.deltaTime, 0f);

        }
    }
}

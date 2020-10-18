using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    float xDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep;
        if (xDirection != 0)
        {
            moveStep = moveSpeed * xDirection * Time.deltaTime;
            transform.position = transform.position + new Vector3(moveStep, 0, 0);
            Debug.Log("Luc am");
            Debug.Log(moveStep);
        } 
    }
}

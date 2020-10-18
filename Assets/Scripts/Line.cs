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
        if (xDirection != 0)
            if ((transform.position.x < -7 && xDirection < 0) || (transform.position.x > 7 && xDirection > 0)) {
                return;
            }
            transform.position = transform.position + new Vector3(moveStep, 0, 0);
        } 
    }
}

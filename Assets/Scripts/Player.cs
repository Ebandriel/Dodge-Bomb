using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10f;
    private float minX = -2.8f;
    private float maxX = 2.8f;
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 temp = transform.position;
        if(h>0)
        {
            temp.x += speed * Time.deltaTime;
            if (temp.x >= maxX)
            {
                temp.x = maxX;
            }
        }
        else if(h<0)
        {
            temp.x -= speed * Time.deltaTime;
            if(temp.x <= minX)
            {
                temp.x = minX;
            }
        }
        transform.position = temp;

    }
}

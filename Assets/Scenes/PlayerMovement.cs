using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        speed = 5;
        if (Input.GetKey("left shift"))
        {
            speed = 10;
        }
        Vector2 direction = new Vector2(inputHorizontal, inputVertical) * speed * Time.deltaTime;
        transform.Translate(direction);

        
    }
}

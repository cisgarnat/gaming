using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float HorizontalInput;
    private float VerticalInput;
    public float speed = 10.0f;
    public float XRange = 12.0f;
    public float ZRange = 6.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -0.50f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //boundery makes the player stay in a range in the screen
        if (transform.position.x < -XRange)
        {
            transform.position = new Vector3(-XRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > XRange)
        {
            transform.position = new Vector3(XRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -ZRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -ZRange);
        }
        if (transform.position.z > ZRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZRange);
        }

        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * VerticalInput * Time.deltaTime * speed);

    }
}


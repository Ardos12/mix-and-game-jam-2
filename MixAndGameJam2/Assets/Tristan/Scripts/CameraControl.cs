using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public float speed = 10;

    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.W))
        {
            direction = Vector3.forward * Time.deltaTime * speed;
            this.transform.Translate(direction);
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction = -Vector3.forward * Time.deltaTime * speed;
            this.transform.Translate(direction);
        }

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.A))
        {
            direction = -Vector3.right * Time.deltaTime * speed;
            this.transform.Translate(direction);
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector3.right * Time.deltaTime * speed;
            this.transform.Translate(direction);
        }
    }
}

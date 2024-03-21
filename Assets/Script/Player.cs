using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement ()
    {
        if (Input.GetKey(KeyCode.W)) transform.position += speed * Time.deltaTime * Vector3.forward;
        if (Input.GetKey(KeyCode.S)) transform.position += speed * Time.deltaTime * Vector3.back;
        if (Input.GetKey(KeyCode.A)) transform.position += speed * Time.deltaTime * Vector3.left;
        if (Input.GetKey(KeyCode.D)) transform.position += speed * Time.deltaTime * Vector3.right;
    }
}

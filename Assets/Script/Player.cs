using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public GameObject shoot;
    public float shootSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }

    public void Movement ()
    {
        if (Input.GetKey(KeyCode.W)) transform.position += speed * Time.deltaTime * Vector3.forward;
        if (Input.GetKey(KeyCode.S)) transform.position += speed * Time.deltaTime * Vector3.back;
        if (Input.GetKey(KeyCode.A)) transform.position += speed * Time.deltaTime * Vector3.left;
        if (Input.GetKey(KeyCode.D)) transform.position += speed * Time.deltaTime * Vector3.right;
    }

    public void Shoot ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject bullet = Instantiate(shoot,transform.position,Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(shootSpeed * Vector3.right);
        }
    }
}

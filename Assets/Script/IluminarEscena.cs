using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IluminarEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lightScene();
    }

    private void lightScene()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            gameObject.GetComponent<Light>().enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            gameObject.GetComponent<Light>().enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPrefabCodigo : MonoBehaviour
{
    public GameObject player;
    public GameObject fence;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, new Vector3(0, 1.38f, 0), Quaternion.identity);
        Instantiate(player, new Vector3(0, 1.38f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public GameObject prefabCube;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate(prefabCube);
        Debug.Log("Modificado el script para hacerle push!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

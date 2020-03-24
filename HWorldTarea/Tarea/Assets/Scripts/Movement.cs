using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W presionada");
            transform.position += new Vector3(0, Input.GetAxis("Vertical"), 0) * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S presionada");
            transform.position += new Vector3(0, Input.GetAxis("Vertical"), 0) * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D presionada");
            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A presionada");
            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.T))
        {
            Debug.Log("T presionada");
            transform.position += Vector3.up * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("G presionada");
            transform.position += Vector3.down * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("F presionada");
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.H))
        {
            Debug.Log("H presionada");
            transform.position += Vector3.right * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.I))
        {
            Debug.Log("I presionada");
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.K))
        {
            Debug.Log("K presionada");
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.L))
        {
            Debug.Log("L presionada");
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.J))
        {
            Debug.Log("J presionada");
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
        }
    }
}

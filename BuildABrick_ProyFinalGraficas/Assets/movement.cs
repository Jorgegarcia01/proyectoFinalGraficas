using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour
{
    public float velocidad;
    private Rigidbody rigid;
    public float velRotacion;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigid.AddForce(transform.forward * velocidad);
        }
        gameObject.transform.Rotate(0, Input.GetAxis("Horizontal") * velRotacion, 0);
    }
}

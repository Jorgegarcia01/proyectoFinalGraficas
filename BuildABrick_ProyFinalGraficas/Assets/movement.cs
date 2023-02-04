using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour
{
    private float velocidad = 2;
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
            Debug.Log("Space key was pressed.");
            gameObject.transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

        }
        gameObject.transform.Rotate(0, Input.GetAxis("Horizontal") * velRotacion, 0);
    }
}

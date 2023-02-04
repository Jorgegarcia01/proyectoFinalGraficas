using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int counter = 0;
    private void OnCollisionEnter(Collision collision)
    {
        counter++;
        Debug.Log("You have:" + counter);
    }
}

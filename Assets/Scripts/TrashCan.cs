using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("YOU LOSE");

            other.transform.position = new Vector3(1, -0.31f, -13.71f);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
    }
}

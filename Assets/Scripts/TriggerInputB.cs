using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInputB : MonoBehaviour
{
    public player p;

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyUp(KeyCode.S) == true && other.tag == "Pulsante")
        {
            p.Point(100);
            other.GetComponent<Collider>().enabled = false;
            Debug.Log("colpito");

        }
        else
        if (other.tag == "Coll")
        {
            p.Point(-100);
            other.GetComponent<Collider>().enabled = false;
        }
        p.isAlive();
    }
}

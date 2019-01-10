using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorrimento : MonoBehaviour {
    public int scorr;
    public int rand;
    public GameObject pulsante;
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P")
        {
            scorr = 45;
            other.transform.position = other.transform.position + new Vector3(0f, 0f, scorr);
        }
        else
        if(other.tag=="pulsante")
        {
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P")
        {

            rand =Random.Range(0, 3);
            
            if (rand == 0)
            {
               
               
                float z = other.transform.position.z+9.0f; 
                Vector3 position = new Vector3(-2.0f, 1,z );
                Instantiate(pulsante, position, Quaternion.identity);
            }
            if (rand == 1)
            {
                
                
                float z = other.transform.position.z + 9.0f;
                Vector3 position = new Vector3(0.0f, 1, z);
                Instantiate(pulsante, position, Quaternion.identity);
            }
            if (rand == 2)
            {
               
               
                float z = other.transform.position.z + 9.0f;
                Vector3 position = new Vector3(2.0f, 1, z);
                Instantiate(pulsante, position, Quaternion.identity);
            }
        }

    }
    
    }

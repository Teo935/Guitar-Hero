using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  using UnityEngine.SceneManagement;
public class player : MonoBehaviour {
    public float MovementSpeed;
    public bool IsAlive;
    public int points=500;
  
    // Use this for initialization
    void Start () {
        MovementSpeed = 0.21f;
        IsAlive = true;
        //Rigidbody rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        movimento();

        float timeLeft = 30.0f;

            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                GameOver();
            }
        
        //CheckInput();

    }
    public void movimento()
    {
       //rb.AddForce(new Vector3(0f,0f, +MovementSpeed));
        transform.position = transform.position + new Vector3(0f, 0f, +MovementSpeed);
       // Debug.Log("mov");
       
    }
    public void CheckInput()
    {
        
        if (IsAlive == false)
       {
           return;
      }
      
        if (Input.GetKeyUp(KeyCode.A) == true)
        {
            points = points + 100;
            Debug.Log(points);
        }
        else
        if (Input.GetKeyUp(KeyCode.S) == true)
        {
            points = points + 100;
            Debug.Log(points);
        }
        else
        if (Input.GetKeyUp(KeyCode.D) == true)
        {
            points = points + 100;
            Debug.Log(points);
        }
        else
        {
            //points = points - 100;
        }
        

    }
       public void Point(int p)
        {
        points = points +p;

    }
    public void isAlive()
    {
        if (points < 0)
        {
            SceneManager.LoadScene("Level1");
        }
    }
    public void GameOver()
    {
        Debug.Log("hai vinto");
    }
}

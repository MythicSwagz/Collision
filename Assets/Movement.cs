using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//AddForce
//AddRelativeForce
//AddTorque
//MovePosition
//MoveRotation
//Velocity
//angularVelocity
public class Movement : MonoBehaviour
{
    public Rigidbody2D rbody;

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    //Lägg allt som har med fysik att göra här.
    void FixedUpdate()
    {
        

        if (Input.GetKey(KeyCode.S))
        {

            rbody.AddForce(new Vector2(0f, -10f));
        }
        if (Input.GetKey(KeyCode.W))
        {

            rbody.AddForce(new Vector2(0f, 10f));
        }
        if (Input.GetKey(KeyCode.D))
        {

            rbody.AddForce(new Vector2(10f, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {

            rbody.AddForce(new Vector2(-10f, 0f));
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        SceneManager.LoadScene("SampleScene");
    }
}

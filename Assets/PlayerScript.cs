using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("VadNiVill", true);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetBool("VadNiVill", false);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            anim.SetTrigger("AAA");
        }
    }
}

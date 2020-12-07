using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public bool active;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "door")
        {
            active = true;
        }
    }
}

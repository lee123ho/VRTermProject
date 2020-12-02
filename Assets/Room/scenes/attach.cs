using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attach : MonoBehaviour
{
    private bool attachObj;
    private FixedJoint _fixedJoint;
    private void Update()
    {
        _fixedJoint = GetComponent<FixedJoint>();
        if (_fixedJoint == null)
            attachObj = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !attachObj)
        {
            var joint = AddFixedJoint();
            joint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
        }
    }

    FixedJoint AddFixedJoint()
    {
        FixedJoint fx = gameObject.AddComponent<FixedJoint>();
        fx.breakForce = 500f;
        attachObj = true;
        return fx;
    }
}
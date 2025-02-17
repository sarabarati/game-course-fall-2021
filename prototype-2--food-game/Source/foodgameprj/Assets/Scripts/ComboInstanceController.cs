﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboInstanceController : MonoBehaviour
{
    public ComboItemConfig config;
    private Rigidbody rigidBody;

    // when player eats the combo item
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.mass = config.weight;
        // rotate randomly when instantiating
        transform.Rotate(0, Random.Range(-45, 45), 0);
    }

    public virtual void OnConsume()
    {
        Debug.Log("PARENT CLASS ON CONSUME");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kill"))
        {
            Destroy(this.gameObject);
        }
    }
}

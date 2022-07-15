using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class legmover : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (Mathf.Abs(target.transform.position.x - transform.position.x) > 3)
        {
            target.transform.position = transform.position;
        }
    }
}
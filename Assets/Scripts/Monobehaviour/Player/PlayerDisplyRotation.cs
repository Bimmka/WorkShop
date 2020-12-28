using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisplyRotation : MonoBehaviour
{
    private Transform startTransform;
    void Start()
    {
        startTransform = transform;
    }

    void Update()
    {
        transform.eulerAngles = startTransform.eulerAngles;
        transform.position = startTransform.position;
    }
}

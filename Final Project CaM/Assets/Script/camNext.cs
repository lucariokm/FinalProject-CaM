﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class camNext : MonoBehaviour
{
 public Transform player;
    private Vector3 offset;
    public float smoothSpeed = 0.125f;
    // Start is called before the first frame update
    void Start()
    {
        offset= transform.position - player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;

    }
}
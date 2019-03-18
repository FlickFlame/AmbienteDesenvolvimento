﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacao : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float So = transform.position.x;
        float S = So + MoveSpeed * Time.deltaTime;
        transform.position = new Vector3(S, transform.position.y, transform.position.z);
    }
}
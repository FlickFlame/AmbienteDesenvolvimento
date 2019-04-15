using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDelay : MonoBehaviour
{
    public float delay = 1f;

    void Start(){
        Destroy(gameObject, delay);
    }
}

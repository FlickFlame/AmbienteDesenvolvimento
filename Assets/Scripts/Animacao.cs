using System.Collections;
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
        float HorizontalInput = Input.GetAxisRaw("Horizontal");
        float VerticalInput = Input.GetAxisRaw("Vertical");

        Vector3 velocity = new Vector3(HorizontalInput,VerticalInput,0f) * MoveSpeed;

        transform.position = transform.position + velocity * Time.deltaTime;
    }
}

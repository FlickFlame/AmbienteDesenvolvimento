using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class SceneManage : MonoBehaviour
{
    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-2f,0f,0f);
    [SerializeField]
    private Transform Tape = null;

    void Awake(){
        Assert.IsNotNull(Tape);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
    }
}

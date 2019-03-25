using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;

    public GameObject CoinParticle;
    void Awake(){
        if(instance == null){
            instance = this;
        }
    }
    public void ShowCoinParticle(GameObject obj){
        Instantiate(CoinParticle, obj.transform.position,Quaternion.identity);
    }
}

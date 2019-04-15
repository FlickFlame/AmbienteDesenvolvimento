using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSFX audiosfx;
    
    void Awake(){
        
        if (instance == null){
            instance = this;
        }
    }

        public void PlaySoundCoinPickup(GameObject obj){
        AudioSource.PlayClipAtPoint(audiosfx.coinPickup, obj.transform.position);
    }
}

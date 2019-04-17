using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            SFXManager.instance.ShowCoinParticle(other.gameObject);
            AudioManager.instance.PlaySoundCoinPickup(other.gameObject);
            Destroy(other.gameObject);
            LevelManager.instance.IncrementCoinCount();
        }

        if (other.gameObject.CompareTag("Gift"))
        {
            StopMusicTape();
            AudioManager.instance.PlaySoundLevelComplete(gameObject);
            Destroy(gameObject);
        }

        else if (other.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            KillPlayer();
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Area"))
        {
            KillPlayer();
        }

    }

    void StopMusicTape()
    {
        Camera.main.GetComponentInChildren<AudioSource>().mute = true;
        LevelManager.instance.SetTapeSpeed(0);
    }

    void KillPlayer()
    {
        StopMusicTape();
        AudioManager.instance.PlaySoundFail(gameObject);
        Destroy(gameObject);
        SFXManager.instance.ShowDieParticles(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    private PlayerJump playerJumpScript;

    private void Start()
    {
        playerJumpScript=GetComponent<PlayerJump>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            playerJumpScript.sm.PlayCoinCollect();
            Destroy(other.gameObject);
        }
    }
}

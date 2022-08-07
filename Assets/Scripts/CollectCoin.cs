using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    private PlayerJump playerJumpScript;
    public int coin=0;
    [SerializeField] Vector3 Checkpoint;
    [SerializeField] private GameObject finishLine;

    private void Start()
    {
        finishLine.SetActive(false);  
        playerJumpScript=GetComponent<PlayerJump>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            coin++;
            playerJumpScript.sm.PlayCoinCollect();
            Debug.Log("Coins Collected: "+coin);
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("Hazard"))
        {
            playerJumpScript.sm.PlayHazardSound();
            Destroy(other.gameObject);
            transform.position=Checkpoint;
        }   
    }
    private void Update()
    {
        if(coin==20)
        {
            finishLine.SetActive(true);  
            playerJumpScript.sm.PlayWinSound();
        }
    }
}

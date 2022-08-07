using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantDeath : MonoBehaviour
{
    private PlayerJump playerJumpScript;
    [SerializeField] Vector3 Checkpoint;

    private void Start()
    {
        playerJumpScript=GetComponent<PlayerJump>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hazard"))
            playerJumpScript.sm.PlayHazardSound();
            Destroy(other.gameObject);
            transform.position=Checkpoint;
    }
}

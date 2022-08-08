using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    [SerializeField] private Text healthCounter;
    public int health=3;
    private PlayerJump playerJumpScript;

    void Start()
    {
        playerJumpScript=GetComponent<PlayerJump>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && health>0)
        {
            health--;
            playerJumpScript.sm.PlayEnemySound();
        }   

        if(health==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void Update()
    {
        healthCounter.text=("" + health);
    }
}

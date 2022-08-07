using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerousPlatform : MonoBehaviour
{
    [SerializeField] private GameObject DangerousCube;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Invoke("HideCube", 1);
        }
    }
    private void HideCube()
    {
        DangerousCube.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{
    [SerializeField] private Text myText;
    [SerializeField] private int myNumber;

    private void Update()
    {
        myText.text=("" + myNumber);
    }

    public void ChangeNumber()
    {
        myNumber=Random.Range(1,101);
    }
}

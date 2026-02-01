using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformCounter : MonoBehaviour
{
    int score = 0; //(for reusing as a point counter)

    [SerializeField] Text pointCounter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("platformCounter"))
        {
            score++; //(for brining score higher)

            pointCounter.text = "Platform: " + score;
        }
    }
}

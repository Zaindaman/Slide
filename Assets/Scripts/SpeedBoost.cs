using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{

    public PlayerMovement PM;

    //int platform; (for reusing as a point counter)

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("speedTrigger"))
        {
            Debug.Log("Faster");
            PM.speedMultiplier += 3;
        }
    }
}

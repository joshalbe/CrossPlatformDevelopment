using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGoalBehavior : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}

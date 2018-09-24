using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {

    private void OnTriggerEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

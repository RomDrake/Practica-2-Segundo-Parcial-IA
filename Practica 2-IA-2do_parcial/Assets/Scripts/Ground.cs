using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
    private Move player;

    // Use this for initialization
    void Start()
    {
        player = GetComponentInParent<Move>();
    }
}

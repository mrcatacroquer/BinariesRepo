using UnityEngine;
using System.Collections;

public class endgame : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        GameControlScript.current.BirdDied();
    }
}

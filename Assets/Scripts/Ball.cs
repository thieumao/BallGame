using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision)  {
        if (collision.gameObject.CompareTag("Player")) {
            Debug.Log("Da va cham");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("DeathZone")) {
            Debug.Log("Da va cham DeathZone");
        }
    }
}

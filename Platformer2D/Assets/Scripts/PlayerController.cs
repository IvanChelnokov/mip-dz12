using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    void start() {
        rb = GetComponent<Rigidbody2D>();
    } 

    void Update() {
        rb.velocity = new Vector2(1f, 0f);
    }
}
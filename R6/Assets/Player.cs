using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;

    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        float moveY = Input.GetAxisRaw("Vertical");
        m_Rigidbody2D.velocity = new Vector2(12 * moveX, 12 * moveY);
    }

}






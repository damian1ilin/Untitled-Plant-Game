using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float m_movementSpeed = 1;

    private Rigidbody2D m_rb;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementInput();
    }

    private void MovementInput()
    {
        m_rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * m_movementSpeed, Input.GetAxisRaw("Vertical") * m_movementSpeed);
    }
}

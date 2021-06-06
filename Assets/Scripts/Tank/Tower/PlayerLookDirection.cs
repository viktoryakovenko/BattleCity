using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookDirection: LookDirection
{
    private Vector2 mousePos;
    public Camera cam;
    public Rigidbody2D rb;

    public override void LookAtPos()
    {
        transform.position = rb.position;

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}

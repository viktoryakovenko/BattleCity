using UnityEngine;

public class Player : Tank
{
    public new void Update()
    {
        body.Move(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Input.GetMouseButton(0))
        {
            StartCoroutine(gun.Shoot());
        }
        base.Update();
    }
}

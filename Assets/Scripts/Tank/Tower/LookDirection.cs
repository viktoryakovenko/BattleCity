using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LookDirection: MonoBehaviour
{
    public abstract void LookAtPos();

    private void Update()
    {
        LookAtPos();
    }
}

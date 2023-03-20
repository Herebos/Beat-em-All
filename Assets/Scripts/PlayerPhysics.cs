using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    public void Move(Vector2 moveAmout)
    {
        transform.Translate(moveAmout);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenDevice : MonoBehaviour
{
    [SerializeField] Vector3 dPos;

    private bool open;

    public void Operate()
    {
        if (open)
        {
            iTween.MoveBy(gameObject, -dPos, 1);
        }
        else
        {
            iTween.MoveBy(gameObject, dPos, 1);
        }
        open = !open;
    }
}

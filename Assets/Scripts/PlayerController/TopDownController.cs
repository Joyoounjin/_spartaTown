using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnWalkEvent; 
    public void CallWalkEvent(Vector2 direction)
    {
        OnWalkEvent?.Invoke(direction);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMemento : MonoBehaviour
{
    public Color Color { get; private set; }

    public ColorMemento(Color color)
    {
        Color = color;
    }
}

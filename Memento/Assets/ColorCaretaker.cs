using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCaretaker : MonoBehaviour
{
    private Stack<ColorMemento> colorHistory = new Stack<ColorMemento>();

    public void SaveState(ColorMemento memento)
    {
        colorHistory.Push(memento);
    }

    public ColorMemento RestoreState()
    {
        if (colorHistory.Count > 0)
        {
            ColorMemento memento = colorHistory.Peek();
            colorHistory.Pop(); // Discard the latest state
            return memento;
        }
        else
        {
            Debug.LogWarning("No color state to restore.");
            return null;
        }
    }
}

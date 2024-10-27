using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public CubeController cubeController;
    private ColorCaretaker caretaker = new ColorCaretaker();

    void Start()
    {
        caretaker.SaveState(new ColorMemento(cubeController.GetColor()));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            caretaker.SaveState(new ColorMemento(cubeController.GetColor()));
            Color newColor = new Color(Random.value, Random.value, Random.value);
            cubeController.SetColor(newColor);
        }

        // On pressing U, restore the previous color state
        if (Input.GetKeyDown(KeyCode.U))
        {
            ColorMemento previousColor = caretaker.RestoreState();
            cubeController.SetColor(previousColor.Color);
        }
    }
}

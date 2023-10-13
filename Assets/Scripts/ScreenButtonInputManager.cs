using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenButtonInputManager : MonoBehaviour
{
    [SerializeField] PlayerController player;
    private ICommand command;
    [SerializeField] private Button leftButton;
    [SerializeField] private Button rightButton;
    private bool leftPress;
    private bool rightPress;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void LeftMovement()
    {
        command = new MoveCommand(new Vector3(-1, 0, 0), 2, player);
        command.Execute();
    }

    public void RightMovement()
    {
        command = new MoveCommand(new Vector3(1, 0, 0), 2, player);
        command.Execute();

    }

    private void Movement()
    {
        if (leftPress)
        {
            LeftMovement();
        }
        if (rightPress)
        {
            RightMovement();
        }
    }

    public void LeftPress(bool verdad) { leftPress = verdad; }
    public void RightPress(bool verdad)
    {
        rightPress= verdad;
    }


}

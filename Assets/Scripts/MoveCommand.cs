using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand :  ICommand
{
    Vector3 direction;
    int speed;
    PlayerController receptor;
 public MoveCommand(Vector3 direction, int speed, PlayerController receptor)
    {
        this.direction = direction;
        this.speed = speed;
        this.receptor = receptor;

    }

    public void Execute() 
    {
        receptor.Movement(direction,speed);
    }
}

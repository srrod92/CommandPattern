using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputController : MonoBehaviour
    {

    [SerializeField] PlayerController player;
    [SerializeField] ICommand command;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputCheck();   
    }

    public void InputCheck()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            command = new MoveCommand(new Vector3(1, 0, 0), 2, player);
            command.Execute();        
        }
        if( Input.GetKey(KeyCode.A)) 
        {
            command = new MoveCommand(new Vector3(-1, 0, 0), 2, player);
            command.Execute();
        }
    }
}

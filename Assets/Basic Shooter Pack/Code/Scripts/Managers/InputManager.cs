using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interface for handling input events

// InputManager that delegates input handling to specific handlers
public class InputManager:MonoBehaviour
{
    public static InputManager instance;

    public Joystick Obj_joystick;
    
    private IJoystickInputHandler _joystick;
    private IMouseInputHandler _mouse;

    public IJoystickInputHandler Joystick => _joystick;
    public IMouseInputHandler Mouse => _mouse;

   private void Awake()
   {
       instance = this;
       
       _joystick = new JoystickInputHandler();
       _mouse = new MouseInputHandler();
        
       _joystick.SetJoystick(Obj_joystick);
   }
   
}
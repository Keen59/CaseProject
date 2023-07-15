using UnityEngine;

public interface IJoystickInputHandler
{
    void SetJoystick(Joystick joystick);
    Vector3 GetJoystickInput();
}

public interface IMouseInputHandler
{
    bool GetMouseInput();
}

public class JoystickInputHandler : IJoystickInputHandler
{
    private Joystick _joystick;

    public void SetJoystick(Joystick joystick)
    {
        _joystick = joystick;
    }
    
    public Vector3 GetJoystickInput()
    {
        Vector3 InputVector = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
        return InputVector;
    }
    
}

public class MouseInputHandler : IMouseInputHandler
{
    public bool GetMouseInput()
    {
        // Get mouse input and return the value as bool
        bool isMouseButtonPressed = Input.GetMouseButton(0);
        return isMouseButtonPressed;
    }
}
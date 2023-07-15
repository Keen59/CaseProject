using UnityEngine;

public class CharacterController : Character
{
    private ICharacterMovement ICharacterMovement;

    private IJoystickInputHandler _joystick;
    private IMouseInputHandler _mouse;

    private void Start()
    {
        ICharacterMovement = GetComponent<ICharacterMovement>();
        
        _joystick = InputManager.instance.Joystick;
        _mouse = InputManager.instance.Mouse;
        
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Animator animator = GetComponent<Animator>();
        CharacterData characterData = new CharacterData(rigidbody, animator);
        ICharacterMovement.SetDatas(characterData);
        
    }

    private void Update()
    {
        if (_mouse.GetMouseInput())
        {
            ICharacterMovement.Attack(Damage);
        }

        ICharacterMovement.Move(_joystick.GetJoystickInput(), Speed);
    }
}
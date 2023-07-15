using UnityEngine;


public class CharacterData
{
    public Rigidbody Rigidbody { get; private set; }
    public Animator Animator { get; private set; }

    public CharacterData(Rigidbody rigidbody, Animator animator)
    {
        Rigidbody = rigidbody;
        Animator = animator;
    }
}
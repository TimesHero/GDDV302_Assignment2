using UnityEngine;
using System;

public class PlayerLocomotion : MonoBehaviour
{
    Animator anim; //talks to animator component, updates mecanim parameters (speed, etc)
    CharacterController cc; //talks to the controller on the player root

    void Awake() //runs when GameObject activates
    {
        anim = GetComponentInChildren<Animator>(); //searches children until Animator found
        cc = GetComponent<CharacterController>(); //looks for controller attached to player
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //self explanatory - left and right
        float z = Input.GetAxisRaw("Vertical"); // ^That^ - forward and back

        Vector2 joypadStick = new Vector2(x, z); //combines both inputs into one "direction"
        float baseSpeed = Mathf.Clamp01(joypadStick.magnitude); //how hard the stick is being pushed
        
        float stickDeadZone = 0.15f; //just in case I've got some drift
        if (baseSpeed < stickDeadZone)
        {
            baseSpeed = 0f; 
        }

        bool isRunning = Input.GetKey(KeyCode.LeftShift); //shift to run
        float targetSpeed = isRunning ? baseSpeed : MathF.Min(baseSpeed, 0.5f);

        anim.SetFloat("Speed", targetSpeed); //lets animator know how fast to blend
    }
}

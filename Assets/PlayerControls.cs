﻿using UnityEngine;

[RequireComponent(typeof(PlatformerCharacter2D))]
public class PlayerControls : MonoBehaviour
{
    private PlatformerCharacter2D character;
    public bool jump;

    public bool canMove;


    void Awake()
    {
        character = GetComponent<PlatformerCharacter2D>();
    }

    void Update()
    {

        if (canMove)
        {
            return;
        }

        // Read the jump input in Update so button presses aren't missed.
#if CROSS_PLATFORM_INPUT
	        if (CrossPlatformInput.GetButtonDown("Jump")) jump = true;
#else
        if (Input.GetButtonDown("Jump")) jump = true;
#endif

    }

    void FixedUpdate()
    {
        // Read the inputs.
        bool crouch = Input.GetKey(KeyCode.LeftControl);
#if CROSS_PLATFORM_INPUT
		float h = CrossPlatformInput.GetAxis("Horizontal");
#else
        float h = Input.GetAxis("Horizontal");
#endif

        // Pass all parameters to the character control script.
        character.Move(h, crouch, jump);

        // Reset the jump input once it has been used.
        jump = false;
    }
}

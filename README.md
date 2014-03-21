Arcade-Unity-Input-Controller
=============================

## Inputs

Mapped Inputs can be found by going to **Edit -> Project Settings -> Input**.  All 4 directions and 3 buttons for each player have been mapped according to the [I-PAC documentation](http://www.ultimarc.com/ipac2.html).  In your game, you should use the GetButton methods and reference the name of the button.

```csharp
// Returns true during the frame the user pressed down the virtual button identified by buttonName.
Input.GetButtonDown("P1_Button1");

// Returns true while the virtual button identified by buttonName is held down.
Input.GetButton("P1_Button1");

// Returns true the first frame the user releases the virtual button identified by buttonName.
Input.GetButtonUp("P3_Button1");
```
## Install InputManager

In the *ProjectSettings* directory exists the **InputManager.asset** which can replace any existing InputManager.asset in your project.  It's a good idea to branch your code before overriding the InputManager.asset since the input mappings are not intuitive and can affect local testing of your game.

## Test Scene

In the project exists a Main.scene which can be used to test inputs on the actual arcade box.  In the scene are two lights next to each possible input for each player.  The light on the left will turn yellow while the input is in the ON state and then turn off when there is no input.  The light on the right will turn from red to green the first time the input for that button is detected.

## Button Names

#### Player 1
- P1_Up
- P1_Down
- P1_Left
- P1_Right
- P1_Button1
- P1_Button2 
- P1_Button3

#### Player 2
- P2_Up
- P2_Down
- P2_Left
- P2_Right
- P2_Button1
- P2_Button2
- P2_Button3 

#### Player 3
- P3_Up
- P3_Down
- P3_Left
- P3_Right
- P3_Button1 
- P3_Button2
- P3_Button3 

#### Player 4
- P4_Up
- P4_Down
- P4_Left
- P4_Right
- P4_Button1 
- P4_Button2
- P4_Button3
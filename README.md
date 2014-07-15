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

This table lists the strings used in the InputManager.asset as well as the keyboard mappings used by the IPAC controller.  If you are not using Unity and want to map your inputs to those used by the arcade cabinet, please use the tables below.

#### Forced Quit

Button     |  Key
-----------|-------
Force Quit | C


#### Player 1

Button     | Key
-----------|-----
P1_Up      | up arrow
P1_Down    | down arrow
P1_Left    | left arrow
P1_Right   | right arrow
P1_Button1 | left ctrl
P1_Button2 | left alt
P1_Button3 | space

#### Player 2

Button     | Key
-----------|-----
P2_Up      | R
P2_Down    | F
P2_Left    | D
P2_Right   | G
P2_Button1 | A
P2_Button2 | S
P2_Button3 | Q

#### Player 3

Button     | Key
-----------|-----
P3_Up      | I
P3_Down    | K
P3_Left    | J
P3_Right   | L
P3_Button1 | [
P3_Button2 | ]
P3_Button3 | enter

#### Player 4

Button     | Key
-----------|-----
P4_Up      | Y
P4_Down    | N
P4_Left    | V
P4_Right   | U
P4_Button1 | B
P4_Button2 | E
P4_Button3 | H

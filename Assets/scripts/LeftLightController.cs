using UnityEngine;
using System.Collections;

public class LeftLightController : MonoBehaviour
{
    public Animator p1_u;
    public Animator p1_d;
    public Animator p1_l;
    public Animator p1_r;
    public Animator p1_1;
    public Animator p1_2;
    public Animator p1_3;

    public Animator p2_u;
    public Animator p2_d;
    public Animator p2_l;
    public Animator p2_r;
    public Animator p2_1;
    public Animator p2_2;
    public Animator p2_3;

    public Animator p3_u;
    public Animator p3_d;
    public Animator p3_l;
    public Animator p3_r;
    public Animator p3_1;
    public Animator p3_2;
    public Animator p3_3;

    public Animator p4_u;
    public Animator p4_d;
    public Animator p4_l;
    public Animator p4_r;
    public Animator p4_1;
    public Animator p4_2;
    public Animator p4_3;
	
	void Update () 
    {
        // BUTTON DOWN
        if (Input.GetButtonDown("P1_Up"))      { p1_u.SetBool("holding", true); }
        if (Input.GetButtonDown("P1_Down"))    { p1_d.SetBool("holding", true); }
        if (Input.GetButtonDown("P1_Left"))    { p1_l.SetBool("holding", true); }
        if (Input.GetButtonDown("P1_Right"))   { p1_r.SetBool("holding", true); }
        if (Input.GetButtonDown("P1_Button1")) { p1_1.SetBool("holding", true); }
        if (Input.GetButtonDown("P1_Button2")) { p1_2.SetBool("holding", true); }
        if (Input.GetButtonDown("P1_Button3")) { p1_3.SetBool("holding", true); }

        if (Input.GetButtonDown("P2_Up"))      { p2_u.SetBool("holding", true); }
        if (Input.GetButtonDown("P2_Down"))    { p2_d.SetBool("holding", true); }
        if (Input.GetButtonDown("P2_Left"))    { p2_l.SetBool("holding", true); }
        if (Input.GetButtonDown("P2_Right"))   { p2_r.SetBool("holding", true); }
        if (Input.GetButtonDown("P2_Button1")) { p2_1.SetBool("holding", true); }
        if (Input.GetButtonDown("P2_Button2")) { p2_2.SetBool("holding", true); }
        if (Input.GetButtonDown("P2_Button3")) { p2_3.SetBool("holding", true); }

        if (Input.GetButtonDown("P3_Up"))      { p3_u.SetBool("holding", true); }
        if (Input.GetButtonDown("P3_Down"))    { p3_d.SetBool("holding", true); }
        if (Input.GetButtonDown("P3_Left"))    { p3_l.SetBool("holding", true); }
        if (Input.GetButtonDown("P3_Right"))   { p3_r.SetBool("holding", true); }
        if (Input.GetButtonDown("P3_Button1")) { p3_1.SetBool("holding", true); }
        if (Input.GetButtonDown("P3_Button2")) { p3_2.SetBool("holding", true); }
        if (Input.GetButtonDown("P3_Button3")) { p3_3.SetBool("holding", true); }

        if (Input.GetButtonDown("P4_Up"))      { p4_u.SetBool("holding", true); }
        if (Input.GetButtonDown("P4_Down"))    { p4_d.SetBool("holding", true); }
        if (Input.GetButtonDown("P4_Left"))    { p4_l.SetBool("holding", true); }
        if (Input.GetButtonDown("P4_Right"))   { p4_r.SetBool("holding", true); }
        if (Input.GetButtonDown("P4_Button1")) { p4_1.SetBool("holding", true); }
        if (Input.GetButtonDown("P4_Button2")) { p4_2.SetBool("holding", true); }
        if (Input.GetButtonDown("P4_Button3")) { p4_3.SetBool("holding", true); }

        // BUTTON UP
        if (Input.GetButtonUp("P1_Up"))      { p1_u.SetBool("holding", false); }
        if (Input.GetButtonUp("P1_Down"))    { p1_d.SetBool("holding", false); }
        if (Input.GetButtonUp("P1_Left"))    { p1_l.SetBool("holding", false); }
        if (Input.GetButtonUp("P1_Right"))   { p1_r.SetBool("holding", false); }
        if (Input.GetButtonUp("P1_Button1")) { p1_1.SetBool("holding", false); }
        if (Input.GetButtonUp("P1_Button2")) { p1_2.SetBool("holding", false); }
        if (Input.GetButtonUp("P1_Button3")) { p1_3.SetBool("holding", false); }

        if (Input.GetButtonUp("P2_Up"))      { p2_u.SetBool("holding", false); }
        if (Input.GetButtonUp("P2_Down"))    { p2_d.SetBool("holding", false); }
        if (Input.GetButtonUp("P2_Left"))    { p2_l.SetBool("holding", false); }
        if (Input.GetButtonUp("P2_Right"))   { p2_r.SetBool("holding", false); }
        if (Input.GetButtonUp("P2_Button1")) { p2_1.SetBool("holding", false); }
        if (Input.GetButtonUp("P2_Button2")) { p2_2.SetBool("holding", false); }
        if (Input.GetButtonUp("P2_Button3")) { p2_3.SetBool("holding", false); }

        if (Input.GetButtonUp("P3_Up"))      { p3_u.SetBool("holding", false); }
        if (Input.GetButtonUp("P3_Down"))    { p3_d.SetBool("holding", false); }
        if (Input.GetButtonUp("P3_Left"))    { p3_l.SetBool("holding", false); }
        if (Input.GetButtonUp("P3_Right"))   { p3_r.SetBool("holding", false); }
        if (Input.GetButtonUp("P3_Button1")) { p3_1.SetBool("holding", false); }
        if (Input.GetButtonUp("P3_Button2")) { p3_2.SetBool("holding", false); }
        if (Input.GetButtonUp("P3_Button3")) { p3_3.SetBool("holding", false); }

        if (Input.GetButtonUp("P4_Up"))      { p4_u.SetBool("holding", false); }
        if (Input.GetButtonUp("P4_Down"))    { p4_d.SetBool("holding", false); }
        if (Input.GetButtonUp("P4_Left"))    { p4_l.SetBool("holding", false); }
        if (Input.GetButtonUp("P4_Right"))   { p4_r.SetBool("holding", false); }
        if (Input.GetButtonUp("P4_Button1")) { p4_1.SetBool("holding", false); }
        if (Input.GetButtonUp("P4_Button2")) { p4_2.SetBool("holding", false); }
        if (Input.GetButtonUp("P4_Button3")) { p4_3.SetBool("holding", false); }
	}
}

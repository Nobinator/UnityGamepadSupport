using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextUpdater : MonoBehaviour {

    public Text t;
    public GamepadListener gpl;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		t.text =
        	"1st LSX1 : "+gpl.getLeftStickX()+'\n'+
            "2nd LSY1 : "+gpl.getLeftStickY()+'\n'+
            "3rd RSX1 : "+gpl.getRightStickX()+'\n'+
            //"4th  	  : "+Input.GetAxis("D")+'\n'+
            "5th RSY1 : "+gpl.getRightStickY()+'\n'+
            "6th DPAD : "+gpl.getDpadX()+'\n'+
            "7th DPAD : "+gpl.getDpadY()+'\n'+
            //"8th : "+Input.GetAxis("H")+'\n'+
            //"9th : "+Input.GetAxis("I")+'\n'+
            //"10th : "+Input.GetAxis("J")+'\n'+
            //"11th : "+Input.GetAxis("K");
        	"X :" +(gpl.getX())+'\n'+
            "Y :" +(gpl.getY())+'\n'+
            "A :" +(gpl.getA())+'\n'+
            "B :" +(gpl.getB())+'\n'+
            "LB :" +(gpl.getLeftBumper())+'\n'+
            "RB :" +(gpl.getRightBumper())+'\n'+
        	"LS :" +(gpl.getLeftShift())+'\n'+
			"RS :" +(gpl.getRightShift())+'\n'+
            "ST :" +(gpl.getStart())+'\n'+
            "SL :" +(gpl.getSelect());
    }
}

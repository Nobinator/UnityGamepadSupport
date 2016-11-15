using UnityEngine;
using System.Collections;
/*
    EN : Component for getting Gamepad actions
    RU : Компонент для получения действий на геймпаде
*/
public class GamepadListener : MonoBehaviour {

    public float getLeftStickX(){
        // X axis
        return round(Input.GetAxis("LSX1"));
    }

    public float getLeftStickY(){
        // Y axis invert
        return round(Input.GetAxis("LSY1"));
    }

    public float getRightStickX(){
        // 3rd axis
        return round(Input.GetAxis("RSX1"));
    }

    public float getRightStickY(){
        // 5th axis invert
        return round(Input.GetAxis("RSY1"));
    }

    public float getDpadX(){
        // 6th axis
        return Input.GetAxis("DPX1");
    }

    public float getDpadY(){
        // 7th axis
        return Input.GetAxis("DPY1");
    }

    public float getX(){
        // Joystick button 3
        return Input.GetButton("X1")? 1 : 0;
    }

    public float getY(){
        // Joystick button 0
        return Input.GetButton("Y1")? 1 : 0;
    }

    public float getA(){
        // Joystick button 2
        return Input.GetButton("A1")? 1 : 0;
    }

    public float getB(){
        // Joystick button 1
        return Input.GetButton("B1")? 1 : 0;
    }

    public float getLeftBumper(){
        // Joystick button 4
        return Input.GetButton("LB1")? 1 : 0;
    }

    public float getRightBumper(){
        // Joystick button 5
        return Input.GetButton("RB1")? 1 : 0;
    }

    public float getLeftShift(){
        // Joystick button 6
        return Input.GetButton("LS1")? 1 : 0;
    }

    public float getRightShift(){
        // Joystick button 7
        return Input.GetButton("RS1")? 1 : 0;
    }

    public float getStart(){
        // Joystick button 9
        return Input.GetButton("ST1")? 1 : 0;
    }

    public float getSelect(){
        // Joystick button 8
        return Input.GetButton("SL1")? 1 : 0;
    }

    public float round(float value){
        // (0 .. 0.01) || (-0.01 .. 0)
        if((0 < value && value <0.01f) || (-0.01f<value && value<0))
            return 0;
        else
            return value;
    }
}

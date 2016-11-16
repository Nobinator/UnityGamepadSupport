using UnityEngine;
using System.Collections;
/*
    EN : Component for getting Gamepad actions
    RU : Компонент для получения действий на геймпаде
*/
public class GamepadListener : MonoBehaviour {

    string[] names = {"LSX","LSY","RSX","RSY","DPX","DPY",
        "joystick button 3", // X
        "joystick button 0", // Y
        "joystick button 2", // A
        "joystick button 1", // B
        "joystick button 4", // LB
        "joystick button 5", // RB
        "joystick button 6", // LS
        "joystick button 7", // RS
        "joystick button 9", // ST
        "joystick button 8"  // SL
    };

    public byte id = 1;

    void Awake(){

        for(int i=0;i<6;i++){
            names[i]+=id;
        }
        for(int i=6;i<names.Length;i++){
            // 0123456789
            // joystick button 5
            names[i] = names[i].Insert(9,id+" ");
            Debug.Log("Result"+names[i]);
        }
        Debug.Log(names.Length);
    }

    public float getLeftStickX(){
        // X axis
        return round(Input.GetAxis(names[0]));
    }

    public float getLeftStickY(){
        // Y axis invert
        return round(Input.GetAxis(names[1]));
    }

    public float getRightStickX(){
        // 3rd axis
        return round(Input.GetAxis(names[2]));
    }

    public float getRightStickY(){
        // 5th axis invert
        return round(Input.GetAxis(names[3]));
    }

    public float getDpadX(){
        // 6th axis
        return Input.GetAxis(names[4]);
    }

    public float getDpadY(){
        // 7th axis
        return Input.GetAxis(names[5]);
    }

    public float getX(){
        // Joystick button 3
        return Input.GetKey(names[6])? 1 : 0;
    }

    public float getY(){
        // Joystick button 0
        return Input.GetKey(names[7])? 1 : 0;
    }

    public float getA(){
        // Joystick button 2
        return Input.GetKey(names[8])? 1 : 0;
    }

    public float getB(){
        // Joystick button 1
        return Input.GetKey(names[9])? 1 : 0;
    }

    public float getLeftBumper(){
        // Joystick button 4
        return Input.GetKey(names[10])? 1 : 0;
    }

    public float getRightBumper(){
        // Joystick button 5
        return Input.GetKey(names[11])? 1 : 0;
    }

    public float getLeftShift(){
        // Joystick button 6
        return Input.GetKey(names[12])? 1 : 0;
    }

    public float getRightShift(){
        // Joystick button 7
        return Input.GetKey(names[13])? 1 : 0;
    }

    public float getStart(){
        // Joystick button 9
        return Input.GetKey(names[14])? 1 : 0;
    }

    public float getSelect(){
        // Joystick button 8
        return Input.GetKey(names[15])? 1 : 0;
    }

    public float round(float value){
        // (0 .. 0.01) || (-0.01 .. 0)
        if((0 < value && value <0.01f) || (-0.01f<value && value<0))
            return 0;
        else
            return value;
    }
}

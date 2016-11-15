using UnityEngine;

public class GamepadModel : MonoBehaviour {
    //Buttons
	public GameObject x,y,a,b,start,back,lb,rb;
    //Triggers
    public GameObject ls,rs;
    //Sticks
    public GameObject lstick,rstick,dpad;

    GamepadListener gin;

    void Start(){
        gin = GetComponent<GamepadListener>();
    }


	void Update () {

        x.transform.Translate(0,-gin.getX() * Time.deltaTime,0);
        y.transform.Translate(0,-gin.getY() * Time.deltaTime,0);
        a.transform.Translate(0,-gin.getA() * Time.deltaTime,0);
        b.transform.Translate(0,-gin.getB() * Time.deltaTime,0);

        lb.transform.Translate(0,-gin.getLeftBumper() * Time.deltaTime,0);
        rb.transform.Translate(0,-gin.getRightBumper() * Time.deltaTime,0);
        ls.transform.Translate(0,-gin.getLeftShift() * Time.deltaTime,0);
        rs.transform.Translate(0,-gin.getRightShift() * Time.deltaTime,0);

        start.transform.Translate(0,-gin.getStart() * Time.deltaTime,0);
        back.transform.Translate(0,-gin.getSelect() * Time.deltaTime,0);

        lstick.transform.Translate(gin.getLeftStickX()* Time.deltaTime,gin.getLeftStickY()* Time.deltaTime,0);
        rstick.transform.Translate(gin.getRightStickX()* Time.deltaTime,gin.getRightStickY()* Time.deltaTime,0);
        dpad.transform.Translate(gin.getDpadX()* Time.deltaTime,gin.getDpadY()* Time.deltaTime,0);
	}
}

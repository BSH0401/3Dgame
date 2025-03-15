using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject LiftJoyStick, RightJoyStick;

    float LiftJoyStickX, LiftJoyStickY, RightJoyStickX, RightJoyStickY, AtanRotateZ;
    void Update()
    {
        AtanRotateZ = Mathf.Atan2(LiftJoyStickY-RightJoyStickY, LiftJoyStickX-RightJoyStickX );

        LiftJoyStickY = LiftJoyStick.transform.position.y;
        LiftJoyStickX = LiftJoyStick.transform.position.x;

        RightJoyStickY = RightJoyStick.transform.position.y;
        RightJoyStickX = RightJoyStick.transform.position.x;

        transform.position = new Vector3(0, (LiftJoyStickY + RightJoyStickY) / 2, 0);
        transform.rotation = Quaternion.Euler(0, 0, AtanRotateZ * 180 / Mathf.PI);


    }

}
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private HingeJoint2D bigCrakHINGE;
    private float motorSpeed;
    private float motorTorque;

    void Start()
    {

    }


    private void SetMotor()
    {
        JointMotor2D motorr = bigCrakHINGE.motor;
        motorr.motorSpeed = this.motorSpeed;
        motorr.maxMotorTorque = this.motorTorque;
        bigCrakHINGE.motor = motorr;
    }


    void Update()
    {
        if(TookInput.ThrottleValue != motorSpeed || TookInput.TorqueValue != motorTorque)
        {
            this.motorSpeed = TookInput.ThrottleValue;
            this.motorTorque = TookInput.TorqueValue;
            SetMotor();
            //Debug.Log($"Called Method Set Motor || Speed {this.motorSpeed} | Torque: {this.motorTorque}");
        }
    }
}

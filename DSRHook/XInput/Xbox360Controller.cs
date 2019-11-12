using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XInput;

namespace DSRHook.XInput
{
    public class Xbox360Controller
    {
        Controller controller;
        Gamepad gamepad;
        public bool connected = false;
        public int deadband = 2500;
        public Point leftThumb, rightThumb = new Point(0,0);
        public float leftTrigger, rightTrigger;

        public Xbox360Controller()
        {
            controller = new Controller(UserIndex.One);
            connected = controller.IsConnected;
        }

        public void Update()
        {
            if(!connected) 
                return;

            gamepad = controller.GetState().Gamepad;

            float RX = gamepad.RightThumbX;
            float RY = gamepad.RightThumbY;

            bool A = (gamepad.Buttons & GamepadButtonFlags.A) != 0;
            bool B = (gamepad.Buttons & GamepadButtonFlags.B) != 0;
            bool X = (gamepad.Buttons & GamepadButtonFlags.X) != 0;
            bool Y = (gamepad.Buttons & GamepadButtonFlags.Y) != 0;

            bool Up = (gamepad.Buttons & GamepadButtonFlags.DPadUp) != 0;
            bool Down = (gamepad.Buttons & GamepadButtonFlags.DPadDown) != 0;
            bool Left = (gamepad.Buttons & GamepadButtonFlags.DPadLeft) != 0;
            bool Right = (gamepad.Buttons & GamepadButtonFlags.DPadRight) != 0;

            bool LB = (gamepad.Buttons & GamepadButtonFlags.LeftShoulder) != 0;
            bool RB = (gamepad.Buttons & GamepadButtonFlags.RightShoulder) != 0;

            byte LT = gamepad.LeftTrigger;
            byte RT = gamepad.RightTrigger;

            float magnitude = (float)Math.Sqrt(RX*RX + RY*RY);

            float normalizedRX = RX / magnitude;
            float normalizedRY = RY / magnitude;

            float normalizedMagnitude = 0;

            //check if the controller is outside a circular dead zone
            if (magnitude > Gamepad.RightThumbDeadZone)
            {
                //clip the magnitude at its expected maximum value
                if (magnitude > 32767) magnitude = 32767;
  
                //adjust magnitude relative to the end of the dead zone
                magnitude -= Gamepad.RightThumbDeadZone;

                //optionally normalize the magnitude with respect to its expected range
                //giving a magnitude value of 0.0 to 1.0
                normalizedMagnitude = magnitude / (32767 - Gamepad.RightThumbDeadZone);
            }
            else //if the controller is in the deadzone zero out the magnitude
            {
                magnitude = (float)0.0;
                normalizedMagnitude = (float)0.0;
            }
        }
    }
}

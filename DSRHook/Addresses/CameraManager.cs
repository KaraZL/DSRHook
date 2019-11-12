using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DSRHook.Injection.MemoryProcessReader;

namespace DSRHook.Addresses
{
    public class CameraManager
    {
        public static string CamManBaseAddress => "DarkSoulsRemastered.exe+22FA90";
        public static string ChrFollowCamAddress => "DarkSoulsRemastered.exe+24E36B"; 

        // ----------- CHR FOLLOW CAM

        public static float FovY
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x50");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x50", "float", value.ToString("0.00"));
        }  

        public static float DrawDistance
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x5C");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x5C", "float", value.ToString("0.00"));
        }  

        public static float RotX
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0xE0");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0xE0", "float", value.ToString("0.00"));
        }  

        public static float RotY
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0xE4");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0xE4", "float", value.ToString("0.00"));
        }  

        public static float RotZ
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0xE8");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0xE8", "float", value.ToString("0.00"));
        }  

        public static float PosX
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x100");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x100", "float", value.ToString("0.00"));
        }  

        public static float PosZ
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x104");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x104", "float", value.ToString("0.00"));
        }  

        public static float PosY
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x108");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x108", "float", value.ToString("0.00"));
        }  

        public static float CamRotX
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x140");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x140", "float", value.ToString("0.00"));
        }  

        public static float TargetRotX
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x150");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x150", "float", value.ToString("0.00"));
        }  

        public static float CamFollowSpeed
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x190");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x190", "float", value.ToString("0.00"));
        }  

        public static float XRotSpeedMin
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress}0x60,0x60,0x204");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress}0x60,0x60,0x204", "float", value.ToString("0.00"));
        }  

        public static float YRotSpeedMin
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x208");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x208", "float", value.ToString("0.00"));
        }  

        public static float XRotSpeedMax
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x20C");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x20C", "float", value.ToString("0.00"));
        }  

        public static float YRotSpeedMax
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x210");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x210", "float", value.ToString("0.00"));
        }  

        public static float XRotHiSpeedMin
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x21C");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x21C", "float", value.ToString("0.00"));
        }  

        public static float YRotHiSpeedMin
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x10,0x30");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x10,0x30", "float", value.ToString("0.00"));
        }  

        public static float XRotHiSpeedMax
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x220");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x220", "float", value.ToString("0.00"));
        }  

        public static float YRotHiSpeedMax
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x224");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x224", "float", value.ToString("0.00"));
        }  

        public static float YXRotHiSpeedMax
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x60,0x60,0x228");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x60,0x60,0x228", "float", value.ToString("0.00"));
        }  
        

        // ----------- CAM MAN BASE

        public static float CameraAngX
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x10,0x30");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x10,0x30", "float", value.ToString("0.00"));
        } 

        public static float CameraAngZ
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x10,0x34");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x10,0x34", "float", value.ToString("0.00"));
        } 

        public static float CameraAngY
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x10,0x38");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x10,0x38", "float", value.ToString("0.00"));
        } 

        public static float CameraX
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x10,0x40");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x10,0x40", "float", value.ToString("0.00"));
        } 

        public static float CameraZ
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x10,0x44");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x10,0x44", "float", value.ToString("0.00"));
        } 

        public static float CameraY
        {
            get => Instance.Memory.readFloat($"{CamManBaseAddress},0x10,0x48");
            set => Instance.Memory.writeMemory($"{CamManBaseAddress},0x10,0x48", "float", value.ToString("0.00"));
        } 
    }
}

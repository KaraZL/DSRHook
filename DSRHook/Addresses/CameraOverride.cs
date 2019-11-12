using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSRHook.Injection.MemoryProcessReader;

namespace DSRHook.Addresses
{
    public class CameraOverride
    {
        public static string CameraLock => "DarkSoulsRemastered.exe+01D1E500,0x170,0x128,0x110,0x38";

        public static float CameraDistance
        {
            get => Instance.Memory.readFloat($"{CameraLock},0x1F8");
            set => Instance.Memory.writeMemory($"{CameraLock},0x1F8", "float", value.ToString("0.00"));
        }   

        public static float MaxDownwardCameraRotation
        {
            get => Instance.Memory.readFloat($"{CameraLock},0x1FC");
            set => Instance.Memory.writeMemory($"{CameraLock},0x1FC", "float", value.ToString("0.00"));
        }   

        public static float LockOnCameraAngle
        {
            get => Instance.Memory.readFloat($"{CameraLock},0x200");
            set => Instance.Memory.writeMemory($"{CameraLock},0x200", "float", value.ToString("0.00"));
        }   

        public static float ShiftCameraUp
        {
            get => Instance.Memory.readFloat($"{CameraLock},0x204");
            set => Instance.Memory.writeMemory($"{CameraLock},0x204", "float", value.ToString("0.00"));
        }   

        public static float MaxLockOnDistance
        {
            get => Instance.Memory.readFloat($"{CameraLock},0x208");
            set => Instance.Memory.writeMemory($"{CameraLock},0x208", "float", value.ToString("0.00"));
        }  


        public static float CamFovY
        {
            get => Instance.Memory.readFloat($"{CameraLock},0x20C");
            set => Instance.Memory.writeMemory($"{CameraLock},0x20C", "float", value.ToString("0.00"));
        }   

        
    }
}

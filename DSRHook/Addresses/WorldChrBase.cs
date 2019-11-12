using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSRHook.Injection;
using static DSRHook.Injection.MemoryProcessReader;

namespace DSRHook.Addresses
{
    public class WorldChrBase
    {
        public static string Address => "DarkSoulsRemastered.exe+1D151B0";
        public static string BaseA => "DarkSoulsRemastered.exe+1ACD758";

        //Various

        public static int HandleId
        {
            get => Instance.Memory.readInt($"{Address},0x68,0x8");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x8", "int", value.ToString());
        }   
        
        public static string ModelId
        {
            get => Instance.Memory.readString($"{Address},0x68,0x88");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x88", "string", value);
        } 

        public static int OnlineAreaID
        {
            get => Instance.Memory.readInt($"{Address},0x68,0x354");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x354", "int", value.ToString());
        }  

        public static int IFrameFlag
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x68,0x48,0xA0");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x48,0xA0", "byte", value.ToString());
        }  

        public static int ChrType
        {
            get => Instance.Memory.readInt($"{Address},0x68,0xD4");
            set => Instance.Memory.writeMemory($"{Address},0x68,0xD4", "int", value.ToString());
        }  

        public static int TeamType
        {
            get => Instance.Memory.readInt($"{Address},0x68,0xD8");
            set => Instance.Memory.writeMemory($"{Address},0x68,0xD8", "int", value.ToString());
        }  

        public static int Health
        {
            get => Instance.Memory.readInt($"{Address},0x68,0x3E8");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x3E8", "int", value.ToString());
        }  

        public static int MaxHealth
        {
            get => Instance.Memory.readInt($"{Address},0x68,0x3EC");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x3EC", "int", value.ToString());
        }  

        public static int Stamina
        {
            get => Instance.Memory.readInt($"{Address},0x68,0x3F0");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x3F0", "int", value.ToString());
        }  

        public static int MaxStamina
        {
            get => Instance.Memory.readInt($"{Address},0x68,0x3F4");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x3F4", "int", value.ToString());
        }  

        public static float ModelFade01
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x328");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x328", "float", value.ToString("0.00"));
        }  

        public static float DebugPlaySpeed
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x18,0xA8");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x18,0xA8", "float", value.ToString("0.00"));
        }  

        // -------------- POSITION -----------------
        public static float FacingAngle
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x28,0x4");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x28,0x4", "float", value.ToString("0.00"));
        }  

        public static float X
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x28,0x10");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x28,0x10", "float", value.ToString("0.00"));
        }  

        public static float Z
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x28,0x14");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x28,0x14", "float", value.ToString("0.00"));
        }  

        public static float Y
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x28,0x18");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x28,0x18", "float", value.ToString("0.00"));
        }

        public static float HeadX
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x30,0x110");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x30,0x110", "float", value.ToString("0.00"));
        }  

        public static float HeadZ
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x30,0x114");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x30,0x114", "float", value.ToString("0.00"));
        }  

        public static float HeadY
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x30,0x118");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x30,0x118", "float", value.ToString("0.00"));
        }  

        public static int EnableChrAsm
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x838");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x838", "byte", value.ToString());
        }  

        // -------------- CHR FLAGS ------------------

        //byte 3-8
        public static int DisableMapHit
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x68, 0x104");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68, 0x104", "byte", value.ToString());
        }  

        //byte 6-32
        public static int NoGravity
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x2A5");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x2A5", "byte", value.ToString());
        }  

        //byte 7-64
        public static int ToggleDraw
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x2A6");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x2A6", "byte", value.ToString());
        }  

        //byte 5-16
        public static int NoDead
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x524");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x524", "byte", value.ToString());
        }  

        //byte 6-32
        public static int NoDamage
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x524");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x524", "byte", value.ToString());
        }  

        //byte 7-64
        public static int NoHit
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x524");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x524", "byte", value.ToString());
        }  

        //byte 2-4
        public static int NoStaminaConsumption
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x525");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x525", "byte", value.ToString());
        }  

        //byte 0
        public static int NoAttack
        {
            //0x525
            get => Instance.Memory.readByte($"{Address},0x68,0x524");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x524", "byte", value.ToString());
        } 
        
        //byte 1-2
        public static int NoMove
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x525");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x525", "byte", value.ToString());
        }  

        //byte 3-8
        public static int NoMpConsumption
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x525");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x525", "byte", value.ToString());
        }  

        //byte 7-64
        public static int NoUpdate
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x525");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x525", "byte", value.ToString());
        }  

        //byte 0
        public static int NoGoodsConsume
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x527");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x527", "byte", value.ToString());
        }  


        public static int DisableEventBackreadState
        {
            get => Instance.Memory.readByte($"{Address},0x68,0x28");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x28", "byte", value.ToString());
        }  

        // -------------- ANIMS

        public static float MovementA
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x88,0x10");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x88,0x10", "float", value.ToString("0.00"));
        }  

        public static float MovementB
        {
            get => Instance.Memory.readFloat($"{Address},0x68,0x68,0x88,0x18");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x88,0x18", "float", value.ToString("0.00"));
        }  

        public static int CurrentAnimation
        {
            get => Instance.Memory.readInt($"{Address},0x68,0x68,0x48,0x80");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x68,0x48,0x80", "int", value.ToString());
        }  

        public static int StayAnimIDUpperBody
        {
            get => Instance.Memory.readInt($"{Address},0x68,0x30,0x5D0,0x690");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x30,0x5D0,0x690", "int", value.ToString());
        }  

        public static int StayAnimIDLowerBody
        {
            get => Instance.Memory.readInt($"{Address},0x68,0x30,0x5D0,0x13B0");
            set => Instance.Memory.writeMemory($"{Address},0x68,0x30,0x5D0,0x13B0", "int", value.ToString());
        }

        //Current Location
        public static float CurrentLocationX
        {
            get => Instance.Memory.readFloat($"{BaseA},0x28,0x50,0x20,0x30,0x30");
            set => Instance.Memory.writeMemory($"{BaseA},0x28,0x50,0x20,0x30,0x30", "float", value.ToString("0.00"));
        }

        public static float CurrentLocationZ
        {
            get => Instance.Memory.readFloat($"{BaseA},0x28,0x50,0x20,0x30,0x34");
            set => Instance.Memory.writeMemory($"{BaseA},0x28,0x50,0x20,0x30,0x34", "float", value.ToString("0.00"));
        }

        public static float CurrentLocationY
        {
            get => Instance.Memory.readFloat($"{BaseA},0x28,0x50,0x20,0x30,0x38");
            set => Instance.Memory.writeMemory($"{BaseA},0x28,0x50,0x20,0x30,0x38", "float", value.ToString("0.00"));
        }
    }
}

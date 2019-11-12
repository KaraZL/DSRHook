using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSRHook.Injection.MemoryProcessReader;

namespace DSRHook.Addresses
{
    public class Quelaag
    {
        public static string EnemyQuelaag => "DarkSoulsRemastered.exe+01D1F710,0x8,0x300,0x1C8,0x88"; 

        //Methods

        public static void WrapToPlayer()
        {
           WorldChrBase.CurrentLocationX = CurrentLocationX;
            WorldChrBase.CurrentLocationY = CurrentLocationY+2;
            WorldChrBase.CurrentLocationZ = CurrentLocationZ;
        }

        public static void WrapPlayerToSelf()
        {
            //CurrentLocation = WorldChrBase.CurrentLocation;
        }
        
        public static void AssignHomeToCurrent()
        {
            hPosX = cPosX;
            hPosY = cPosY;
            hPosZ = cPosZ;

            if (cAngle > -0.01 && cAngle < 0.0153)
                hAngle = 0;
            else if (cAngle > 0.0153 && cAngle < 70)
                hAngle = 1;
            else if (cAngle > -2.26 && cAngle < -0.01)
                hAngle = -1;
            else
                hAngle = 100;
        }

        //Properties
        public static int HandleId
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0x8");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x8", "int", value.ToString());
        }

        public static int NpcId
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0x88");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x88", "int", value.ToString());
        }

        public static int CharacterId //Quelaag 528000
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0xC8");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0xC8", "int", value.ToString());
        }

        public static int ChrType
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0xD4");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0xD4", "int", value.ToString());
        }

        public static int TeamType
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0xD8");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0xD8", "int", value.ToString());
        }

        public static int HP
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0x3E8");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x3E8", "int", value.ToString());
        } 

        public static int MaxHP
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0x3EC");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x3EC", "int", value.ToString());
        } 

        public static int MP
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0x3F0");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x3F0", "int", value.ToString());
        } 

        public static int MaxMP
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0x3F4");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x3F4", "int", value.ToString());
        } 

        public static int Stamina
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0x3F8");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x3F8", "int", value.ToString());
        } 

        public static int MaxStamina
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0x3FC");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x3FC", "int", value.ToString());
        } 

        public static int SpeedModifier
        {
            get => Instance.Memory.readInt($"{EnemyQuelaag},0x68,0x18,0xA8");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x68,0x18,0xA8", "int", value.ToString());
        } 

        public static int NoHit
        {
            get => Instance.Memory.readByte($"{EnemyQuelaag},0x524");
            set
            {
                if(value == 0)
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x524", "byte", "0");
                else
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x524", "byte", "64"); //bit 7
            }
        }

        public static int NoDamage
        {
            get => Instance.Memory.readByte($"{EnemyQuelaag},0x524");
            set
            {
                if(value == 0)
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x524", "byte", "0");
                else
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x524", "byte", "32"); //bit 6
            }
        } 

        public static int NoDead
        {
            get => Instance.Memory.readByte($"{EnemyQuelaag},0x524");
            set
            {
                if(value == 0)
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x524", "byte", "0");
                else
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x524", "byte", "16"); //bit 5
            }
        } 

        public static int NoUpdate
        {
            get => Instance.Memory.readByte($"{EnemyQuelaag},0x525");
            set
            {
                if(value == 0)
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x525", "byte", "0");
                else
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x525", "byte", "64"); //bit 7
            }
        } 

        public static int NoAttack
        {
            get => Instance.Memory.readByte($"{EnemyQuelaag},0x525");
            set
            {
                if(value == 0)
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x525", "byte", "0");
                else
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x525", "byte", "1"); //bit 0
            }
        } 

        public static int NoMove
        {
            get => Instance.Memory.readByte($"{EnemyQuelaag},0x525");
            set
            {
                if(value == 0)
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x525", "byte", "0");
                else
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x525", "byte", "2"); //bit 1
            }
        } 

        public static int NoGravity
        {
            get => Instance.Memory.readByte($"{EnemyQuelaag},0x2A5");
            set
            {
                if(value == 0)
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x2A5", "byte", "0");
                else
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x2A5", "byte", "32"); //bit 6
            }
        } 

        public static int EventSuperArmor
        {
            get => Instance.Memory.readByte($"{EnemyQuelaag},0x2A6");
            set
            {
                if(value == 0)
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x2A6", "byte", "0");
                else
                    Instance.Memory.writeMemory($"{EnemyQuelaag},0x2A6", "byte", "1"); //bit 0
            }
        } 

        public static float hPosX //h = home
        {
            get => Instance.Memory.readFloat($"{EnemyQuelaag},0x140");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x140", "float", value.ToString("0.00"));
        }  

        public static float hPosZ
        {
            get => Instance.Memory.readFloat($"{EnemyQuelaag},0x144");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x144", "float", value.ToString("0.00"));
        }  

        public static float hPosY
        {
            get => Instance.Memory.readFloat($"{EnemyQuelaag},0x148");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x148", "float", value.ToString("0.00"));
        }  

        public static float cPosX //c = current
        {
            get => Instance.Memory.readFloat($"{EnemyQuelaag},0x2C0");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x2C0", "float", value.ToString("0.00"));
        }  

        public static float cPosZ
        {
            get => Instance.Memory.readFloat($"{EnemyQuelaag},0x2C4");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x2C4", "float", value.ToString("0.00"));
        }  

        public static float cPosY
        {
            get => Instance.Memory.readFloat($"{EnemyQuelaag},0x2C8");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x2C8", "float", value.ToString("0.00"));
        }

        // 0 --- -0 to 0.0152432918548584
        // 1 --- 0.0152432918548584 to 16.31640625
        // 100 --- -2.26064109802246 to 16.31640625
        // -1 --- -2.26064109802246 to -0.0104026943445206
        //  (front 1) (back -1) (left 0) (right 100)

        public static double hAngle
        {
            get => Instance.Memory.readDouble($"{EnemyQuelaag},0x150");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x150", "double", value.ToString("0.00"));
        }

        public static double cAngle
        {
            get => Instance.Memory.readDouble($"{EnemyQuelaag},0x68,0x28,0x0");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x68,0x28,0x0", "double", value.ToString("0.00"));
        }

        //Current Location
        public static float CurrentLocationX
        {
            get => Instance.Memory.readFloat($"{EnemyQuelaag},0x18,0x28,0x50,0x20,0x30,0x30");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x18,0x28,0x50,0x20,0x30,0x30", "float", value.ToString("0.00"));
        }

        public static float CurrentLocationZ
        {
            get => Instance.Memory.readFloat($"{EnemyQuelaag},0x18,0x28,0x50,0x20,0x30,0x34");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x18,0x28,0x50,0x20,0x30,0x34", "float", value.ToString("0.00"));
        }

        public static float CurrentLocationY
        {
            get => Instance.Memory.readFloat($"{EnemyQuelaag},0x18,0x28,0x50,0x20,0x30,0x38");
            set => Instance.Memory.writeMemory($"{EnemyQuelaag},0x18,0x28,0x50,0x20,0x30,0x38", "float", value.ToString("0.00"));
        }

    
    }
}

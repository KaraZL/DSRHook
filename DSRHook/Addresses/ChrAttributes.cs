using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSRHook.Injection.MemoryProcessReader;

namespace DSRHook.Addresses
{
    public class ChrAttributes
    {
        public static string Address => "DarkSoulsRemastered.exe+728E50";

        public static string Name
        {
            get => Instance.Memory.readString($"{Address},0x10,0x12C");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x12C", "string", value);
        }  

        public static int Sex
        {
            get => Instance.Memory.readInt($"{Address},0x10,0xCA");
            set => Instance.Memory.writeMemory($"{Address},0x10,0xCA", "int", value.ToString());
        }  

        public static int SoulLevel
        {
            get => Instance.Memory.readInt($"{Address},0x10,0x90");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x90", "int", value.ToString());
        }   

        public static int VIT
        {
            get => Instance.Memory.readInt($"{Address},0x10,0x40");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x40", "int", value.ToString());
        }   

        public static int ATN
        {
            get => Instance.Memory.readInt($"{Address},0x10,0x48");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x48", "int", value.ToString());
        }   

        public static int END
        {
            get => Instance.Memory.readInt($"{Address},0x10,0x50");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x50", "int", value.ToString());
        }   

        public static int STR
        {
            get => Instance.Memory.readInt($"{Address},0x10,0x58");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x58", "int", value.ToString());
        }   

        public static int DEX
        {
            get => Instance.Memory.readInt($"{Address},0x10,0x60");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x60", "int", value.ToString());
        }   

        public static int RES
        {
            get => Instance.Memory.readInt($"{Address},0x10,0x88");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x88", "int", value.ToString());
        }   

        public static int INT
        {
            get => Instance.Memory.readInt($"{Address},0x10,0x68");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x68", "int", value.ToString());
        }   

        public static int FTH
        {
            get => Instance.Memory.readInt($"{Address},0x10,0x70");
            set => Instance.Memory.writeMemory($"{Address},0x10,0x70", "int", value.ToString());
        }   
    }
}

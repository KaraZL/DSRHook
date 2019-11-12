using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSRHook.Injection.MemoryProcessReader;

namespace DSRHook.Addresses
{
    public class ChrClassWarp
    {
        public static string Address => "DarkSoulsRemastered.exe+2C89B3";
        public static string BaseC => "DarkSoulsRemastered.exe+2C8B10";

        /*
         * BONFIRE IDS
         * Quelaag's Domain: 1402960
         * DLC Elizabeth: 1212961
         */

        public static int LastBonfire
        {
            get => Instance.Memory.readInt($"{Address},0xB34");
            set => Instance.Memory.writeMemory($"{Address},0xB34", "int", value.ToString());
        }

        public static int AutoSave
        {
            get => Instance.Memory.readByte($"{BaseC},0xB70");
            set => Instance.Memory.writeMemory($"{BaseC},0xB70", "byte", value.ToString());
        }

        public static float StableX
        {
            get => Instance.Memory.readFloat($"{Address},0xBA0");
            set => Instance.Memory.writeMemory($"{Address},0xBA0", "float", value.ToString("0.00"));
        }  

        public static float StableZ
        {
            get => Instance.Memory.readFloat($"{Address},0xBA4");
            set => Instance.Memory.writeMemory($"{Address},0xBA4", "float", value.ToString("0.00"));
        }  

        public static float StableY
        {
            get => Instance.Memory.readFloat($"{Address},0xBA8");
            set => Instance.Memory.writeMemory($"{Address},0xBA8", "float", value.ToString("0.00"));
        }  

        public static float StableAngle
        {
            get => Instance.Memory.readFloat($"{Address},0xBB4");
            set => Instance.Memory.writeMemory($"{Address},0xBB4", "float", value.ToString("0.00"));
        }
    }
}

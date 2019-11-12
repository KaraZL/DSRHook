using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSRHook.Injection.MemoryProcessReader;

namespace DSRHook.Addresses
{
    public class FrpgNet
    {
        public static string Address => "DarkSoulsRemastered.exe+7898FF";

        public static int SoulLevel
        {
            get => Instance.Memory.readInt($"{Address},0xA40");
            set => Instance.Memory.writeMemory($"{Address},0xA40", "int", value.ToString());
        }   

        public static int PhantomType
        {
            get => Instance.Memory.readInt($"{Address},0xA38");
            set => Instance.Memory.writeMemory($"{Address},0xA38", "int", value.ToString());
        }   

        
    }
}

using System;
using System.Windows.Forms;
//using Memory;

namespace DSRHook.Injection
{
    public class MemoryProcessReader
    {
        private string DARKSOULS_NAME = "DarkSoulsRemastered";

        public Mem Memory { get; set; } 
        private bool isOpen;

        public MemoryProcessReader()
        {
            Memory = new Mem();
            isOpen = false;

            int pId = Memory.getProcIDFromName(DARKSOULS_NAME);
            if(pId > 0) isOpen = Memory.OpenProcess(pId);
            if (!isOpen)
                MessageBox.Show("Process has not been opened");

        }

        private static Lazy<MemoryProcessReader> instance = new Lazy<MemoryProcessReader>(() => new MemoryProcessReader());
        public static MemoryProcessReader Instance = instance.Value;

    }

}

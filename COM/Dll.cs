using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace COM {
    // Dynamic-link library (DLL) is Microsoft's implementation of the shared library concept in the Microsoft Windows.
    // Not really connected to COM, COM is independent of langauge and OS
    class Dll {

        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(IntPtr point);

        public Dll() {
            Console.WriteLine("DLL: ");

            Process p = Process.Start("notepad.exe");
            p.WaitForInputIdle();
            IntPtr h = p.MainWindowHandle;

            SetForegroundWindow(h);  //focus on Window

            for (int i = 0; i < 5; i++) {
                System.Threading.Thread.Sleep(1000);
                SendKeys.SendWait("k");
            }
   
            IntPtr processFoundWindow = p.MainWindowHandle;
        }
    }
}

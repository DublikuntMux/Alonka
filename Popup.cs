using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace Alonka;

public partial class Popup : Form
{
    public Popup()
    {
        InitializeComponent();
        timer1.Start();
    }

    private void timer1_Tick(object sender, ElapsedEventArgs e)
    {
        var popup = new Popup();
        new Thread(() => popup.ShowDialog()).Start();
    }
}

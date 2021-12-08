using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Ferramentas.ManipularEventos
{
    public class EventosMouseCofreTJ
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        public int Ps_X { get; set; }

        public int Ps_Y { get; set; }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        private static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        public void InsereSenhaCofre(string SenhaCofre)
        {
            //MessageBox.Show("Olá, Esse é um evento de automação, preciso que você click no ok, deste pop-up, e após coloque o " +
            //ponteiro do seu mouse sobre o icone do cofre virtual, e não mexe no mouse, pois vou utilizar ele, obrigado!", "Robô Jurídico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (Ps_Y != 0 && Ps_X != 0)
            {
                System.Threading.Thread.Sleep(4000);
                Control control = new Control();
                System.Drawing.Point coordenadas = control.PointToClient(Cursor.Position);
                Ps_X = coordenadas.X;
                Ps_Y = coordenadas.Y + 25;

                SetCursorPos(Ps_X, Ps_Y);
                LeftMouseClick(Ps_X, Ps_Y);
                System.Threading.Thread.Sleep(2000);
                SendKeys.Send(SenhaCofre);
                System.Threading.Thread.Sleep(2000);
                SendKeys.SendWait("{ENTER}");
                //MessageBox.Show("TEste ok");
            }
            else
            {
                System.Threading.Thread.Sleep(20000);
                Control control = new Control();
                System.Drawing.Point coordenadas = control.PointToClient(Cursor.Position);
                Ps_X = coordenadas.X;
                Ps_Y = coordenadas.Y + 25;

                SetCursorPos(Ps_X, Ps_Y);
                LeftMouseClick(Ps_X, Ps_Y);
                System.Threading.Thread.Sleep(2000);
                SendKeys.Send(SenhaCofre);
                System.Threading.Thread.Sleep(2000);
                SendKeys.SendWait("{ENTER}");
                //MessageBox.Show("TEste ok");
            }


        }
    }
}

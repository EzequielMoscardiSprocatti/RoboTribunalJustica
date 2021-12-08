using Ferramentas.FrmViews;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas.Macros
{
    public class GravarExecutarMacros
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        private int Ps_X { get; set; }

        private int Ps_Y { get; set; }

        public string SenhaCofre { get; set; }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        bool isDrag = false;
        Rectangle theRectangle = new Rectangle(new Point(0, 0), new Size(0, 0));
        Point startPoint;

        private static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        public void GravarExecutarMacro()
        {
            //verifico se tem macro salva
            if (File.Exists(@"C:\Robo_Juridico\MacroSalva.txt"))
            {
                ExecutarMacro(@"C:\Robo_Juridico\MacroSalva.txt");
            }
            else
            {
                GravarMacro();
                ExecutarMacro(@"C:\Robo_Juridico\MacroSalva.txt");
            }
        }

        private void GravarMacro()
        {
            Control control = new Control();
            FrmMacros popupmacro = new FrmMacros();
            ArrayList position = new ArrayList();
            MessageBox.Show("Inicando Gravação do mouse, após o ok mantenha o curso sobre o item desejado");
            bool log = true;

            while (log == true)
            {
                System.Threading.Thread.Sleep(5000);
                System.Drawing.Point coordenadas = control.PointToClient(Cursor.Position);
                popupmacro.Postion_X = coordenadas.X;
                popupmacro.Postion_Y = coordenadas.Y + 25;
                popupmacro.ShowDialog();
                position.Add(popupmacro.Postion_X + "," + popupmacro.Postion_Y);
                log = popupmacro.StatusProc;
            }

            _ = SalvandoMacro(position);
        }

        private void ExecutarMacro(string Path)
        {
            ArrayList listaDePosicoes = new ArrayList();

            foreach (string line in File.ReadLines(Path))
            {
                listaDePosicoes.Add(line);
            }

            System.Threading.Thread.Sleep(6000);
            int i = 0;
            foreach (string post in listaDePosicoes)
            {
                try
                {
                    int x, y = 0;
                    string[] xy = listaDePosicoes[i].ToString().Split(',');

                    x = int.Parse(xy[0].ToString());
                    y = int.Parse(xy[1].ToString());

                    if (x != 0 || y != 0)
                    {
                        SetCursorPos(x, y);
                        LeftMouseClick(x, y);

                        System.Threading.Thread.Sleep(2000);

                        
                    }
                }
                catch (Exception)
                {

                }


                i++;
            }

            SendKeys.Send(SenhaCofre);
            System.Threading.Thread.Sleep(2000);
            SendKeys.SendWait("{ENTER}");
        }

        private static async Task SalvandoMacro(ArrayList listaDePosicoes)
        {
            string listagem = "";

            for (int i = 0; i < listaDePosicoes.Count; i++)
            {
                listagem += listaDePosicoes[i] + ";";
            }

            string path = @"C:\Robo_Juridico\MacroSalva.txt";
            string[] lines = listagem.Split(';');

            if (!File.Exists(path))
            {
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        File.WriteAllLines(path, lines);
                    }
                }
            }
        }

    }
}

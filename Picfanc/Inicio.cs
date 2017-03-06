using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Picfanc
{
    public partial class Inicio : Form
    {

        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        // 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // 
        // función privada usada para mover el formulario actual 


        private string imgFanOn = @"C:\Users\Soporte\Documents\GitHub\Picfanc\Picfanc\Recursos\The_Fan_On.gif";
        private string imgFanOff = @"C:\Users\Soporte\Documents\GitHub\Picfanc\Picfanc\Recursos\The_Fan_Off.png";

        public Inicio()
        {

            InitializeComponent();
            
            this.BackColor = Color.FromArgb(41, 57, 85); //color fondo formulario

            this.panelBorder.BackColor = Color.FromArgb(155, 167, 183);//color fondo barra 

            //color a separador de botones
            this.sepAutomatico.BackColor = Color.FromArgb(249, 89, 89);
            this.sepManual.BackColor = Color.FromArgb(249, 89, 89);

            //color boton ON OFF Manual
            this.btnOnOff.BackColor = Color.FromArgb(20, 208, 120);

            this.sepManual.Visible = false;//Ocultar separador boton manual

            //Carga de imagenes en las cajas
            this.cargarImagen(this.picAutomatico, imgFanOff);
            this.cargarImagen(this.picManual, imgFanOn);
            

        }

        private void boxCerrar_Click(object sender, EventArgs e)
        {
            // Finalizar el programa
            this.Dispose();
            this.Close();
        }

        // Minimizar la ventana
        private void boxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Mover la ventana con el panel TOP
        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        // cambio de panel manual a Automatico
        private void btnAutomatico_Click(object sender, EventArgs e)
        {
            if(panelAuto.Left == 384)
            {
                panel1.Visible = false;
                panel1.Left = 384;
                sepManual.Visible = false;

                panelAuto.Visible = false;
                panelAuto.Left = 29;
                panelAuto.Visible = true;
                panelAuto.Refresh();
                sepAutomatico.Visible = true;
            }

           /* AnimacionGif an = new AnimacionGif(this.dirGiFan);

            foreach (var a in an.Images)
            {

                this.pictureBox1.Image = a.Image;
                this.pictureBox1.Refresh();

                System.Threading.Thread.Sleep(100);


            }*/
        }


        private void cargarImagen(PictureBox box, string pathImagen)
        {
            box.Image = Image.FromFile(pathImagen);
        }

        // cambio de panel Automatico a Manual
        private void btnManual_Click(object sender, EventArgs e)
        {
            if (panel1.Left == 384)
            {
                panelAuto.Visible = false;
                panelAuto.Left = 384;
                sepAutomatico.Visible = false;

                panel1.Visible = false;
                panel1.Left = 29;
                panel1.Visible = true;
                panel1.Refresh();
                sepManual.Visible = true;
                
            }
        }




    }


}

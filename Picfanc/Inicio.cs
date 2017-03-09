using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        ClsManejadorTemperatura tempMan = null;
        ThreadStart ts = null;
        Thread tr = null;
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
            this.btnOnOff.Visible = false;
            //Carga de imagenes en las cajas
           // this.cargarImagen(this.picAutomatico, imgFanOff);
            //this.cargarImagen(this.picManual, imgFanOn);
            //iniciar();
            //tempMan = new ClsManejadorTemperatura("COM4");

        }

        private void iniciar()
        {
            if (tempMan != null)
            {
                tempMan.detener();
                tempMan = null;
                ts = null;
                tr = null;
            }
            tempMan = new ClsManejadorTemperatura("COM4");// Cargar Hilo para escuchar el puerto serial
            tempMan.Mensaje += new ClsManejadorTemperatura.MensajeDelegate(cmh_Mensaje);
            ts = new ThreadStart(tempMan.run);
            tr = new Thread(ts);
            tr.Start();
            cargarControles();
        }


        public void liberar()
        {
 
        }

        private void boxCerrar_Click(object sender, EventArgs e)
        {
            // Finalizar el programa
            if(this.tempMan != null)
                this.tempMan.detener();
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
            //limpiarControles();
            tempMan.modo = 0;
            sepManual.Visible = false;
            sepAutomatico.Visible = true;
            cargarControles(); //.....................................................................................................................................

            /*if(panelAuto.Left == 384)
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
            */
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
            //limpiarControles();

            sepAutomatico.Visible = false;
            sepManual.Visible = true;
            tempMan.modo = 1;
            /*if (panel1.Left == 384)
            {
                panelAuto.Visible = false;
                panelAuto.Left = 384;
                sepAutomatico.Visible = false;

                panel1.Visible = false;
                panel1.Left = 29;
                panel1.Visible = true;
                panel1.Refresh();
                sepManual.Visible = true;
                
            }*/

            cargarControles(); //.....................................................................................................................................
        }


        private void cargarControles()
        {
            if (tempMan.estadoFan == 1)//ventilador esta encendido
            {
                //lblManualestado.Text = "ON";
                lblAutoEstado.Text = "ON";
                //cargarImagen(imagen,imgFanOn);
                //cargarImagen(picManual, imgFanOn);
                cargarImagen(imagen,imgFanOn);


                btnOnOff.Text = "Apagar ventilador";
                this.btnOnOff.BackColor = Color.FromArgb(249, 89, 89);
                this.btnOnOff.Image = Picfanc.Properties.Resources.Flash_Off_24px;

                //cargarImagen(picManual, imgFanOn);
                //cargarImagen(imagen, imgFanOn);

            }
            else if (tempMan.estadoFan == 2) // ventilador esta apagado
            {
                cargarImagen(imagen, imgFanOff);
                //lblManualestado.Text = "OFF";
                lblAutoEstado.Text = "OFF";
                //cargarImagen(imagen, imgFanOff);
                //cargarImagen(picManual, imgFanOff);

                btnOnOff.Text = "Encender ventilador";
                this.btnOnOff.BackColor = Color.FromArgb(20, 208, 120);
                this.btnOnOff.Image = Picfanc.Properties.Resources.Flash_On_24px;

                //cargarImagen(picManual, imgFanOff);
                //cargarImagen(imagen, imgFanOff);

            }
            if(tempMan.modo == 0)
                this.btnOnOff.Visible = false;
            else if(tempMan.modo == 1)
                this.btnOnOff.Visible = true;
            //lblManualTemp.Text = tempMan.temp.ToString();
            if (tempMan.conexion)
                HabilitarControles(true);
            else
                HabilitarControles(false);

            lblAutoTemp.Text = tempMan.temp.ToString();
        }

        public void HabilitarControles(bool estado)
        {
            this.btnAutomatico.Enabled = estado;
            this.btnManual.Enabled = estado;
            this.btnOnOff.Enabled = estado;
            
        }



        private void cmh_Mensaje(string p)
        {
            if (p == "load")
                this.manajerControles(p);
            else
                this.SetText2(p);
                //cargarControles();
      
            // this.listBox1.Items.Add(p);
            //this.SetText2(p);
        }

        delegate void SetTextCallback2(string text);


        private void manajerControles(string text)
        {
            if (this.lblSalida.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(manajerControles);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                cargarControles();
                
                //this.lblSalida.Text = text;
            }
        }
        private void SetText2(string text)
        {
            if (this.lblSalida.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetText2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //cargarControles();
                this.lblSalida.Text = text;
            }
        }
        
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (tempMan.estadoFan == 2)
                tempMan.estadoFan = 1;
            else if (tempMan.estadoFan == 1)
                tempMan.estadoFan = 2;
            cargarControles(); //.....................................................................................................................................

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        
    }


}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add("---");

            ClaseMultiHilo cmh = new ClaseMultiHilo();
            ClaseMultiHilo cmh2 = new ClaseMultiHilo();

            cmh.Mensaje += new ClaseMultiHilo.MensajeDelegate(cmh_Mensaje);
            cmh2.Mensaje += new ClaseMultiHilo.MensajeDelegate(cmh_Mensaje);
            
            cmh.parametro = 10;
            cmh2.parametro = 10;


            ThreadStart ts = new ThreadStart(cmh.MostrarMensaje);
            Thread t = new Thread(ts);
            ThreadStart ts1 = new ThreadStart(cmh2.MostrarMensaje);
            Thread t1 = new Thread(ts1);
            t.Start();
            t1.Start();

        }


        private void cmh_Mensaje(string p)
        {
            // this.listBox1.Items.Add(p);
            this.SetText2(p);
        }

        delegate void SetTextCallback2(string text);

        private void SetText2(string text)
        {
            if (this.listBox1.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetText2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.listBox1.Items.Add(text);
            }
        }
    }

    // Clase para lanzar en un hilo
    class ClaseMultiHilo
    {
        public delegate void MensajeDelegate(string p);
        public event MensajeDelegate Mensaje;

        public int parametro;
        public void MostrarMensaje()
        {
            for (int i = 0; i < parametro; i++)
            {
                if((i%2) == 0)
                    OnMensaje("Parametro " + i);
                Thread.Sleep(1000);
            }
        }
        protected void OnMensaje(string p)
        {
            if (Mensaje != null)
                Mensaje(p);
        }
    }
}

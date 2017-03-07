using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;

namespace Picfanc
{
    class ClsManejadorTemperatura
    {
        public delegate void MensajeDelegate(string p);
        public event MensajeDelegate Mensaje;

        private ClsSerial mySerial;
        private bool ejecucion;
        private string recibido;
        public int modo;
        public int temp;
        public bool conexion;
        public int estadoFan;

        public ClsManejadorTemperatura(string nombrePuerto)
        {
            try
            {
                conexion = false;
                temp =32;
                estadoFan = 2;
                modo = 0; // 0 automatico, 1 manual
                recibido = "DATA";
                ejecucion = true;
                mySerial = new ClsSerial(nombrePuerto);
                mySerial.RecibidorDatos(this.DatosRecibidos);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void run()
        {
            while (ejecucion)
            {

                try
                {
                    if (mySerial.obtenerPuerto().IsOpen)
                    {
                        if (modo == 0)//Fan automatico
                        {
                            int i = 0;
                            bool res = int.TryParse(recibido, out i);

                            if (res)
                            {
                                temp = Int32.Parse(recibido);
                                if (temp > 30)
                                {
                                    //OnMensaje("AonFan"); //encender ventilador en grafica 
                                    mySerial.enviarDatos("1"); // enviar valor para encender ventilador cuando la temperatura sea mayor a 30 grador 
                                    estadoFan = 1;
                                }
                                else if (temp < 30)
                                {
                                    //OnMensaje("AoffFan");  // apagar ventilador en grafica
                                    mySerial.enviarDatos("2"); // enviar valor para apagar ventilador cuando la temperatura sea menor a 30 grados
                                    estadoFan = 2;
                                }
                            }
                            else
                            {

                                // procesar no numerico
                                //OnMensaje("valores no numerico");
                                //  OnMensaje("AonFan");
                            }
                            //OnMensaje("30");

                        }
                        else if (modo == 1)//Fan Manual
                        {
                            if (estadoFan == 1)
                            {
                                mySerial.enviarDatos("2");// enviar valor para apagar ventilador
                            }
                            else if (estadoFan == 2)
                                mySerial.enviarDatos("1"); // enviar valor para encender ventilador

                        }
                        //OnMensaje(estadoFan.ToString());
                        OnMensaje("Conectado...");
                        mySerial.enviarDatos("0");
                        OnMensaje("load");
                    }
                    else
                    {
                        OnMensaje("Abriendo Puerto");
                        OnMensaje(estadoFan.ToString());
                        mySerial.conectar();
                        conexion = true;

                    }
                }
                catch (Exception ex)
                {
                    conexion = false;
                    OnMensaje("Error: " + ex.Message);
                }
                Thread.Sleep(1000);
            }
            mySerial.cerrar();
        }

        public void detener()
        {
            ejecucion = false;
            
        }

        protected void OnMensaje(string p)
        {
            if (Mensaje != null)
                Mensaje(p);
        }

        private void DatosRecibidos(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort puerto = (SerialPort)sender;
                recibido = puerto.ReadLine();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }


}

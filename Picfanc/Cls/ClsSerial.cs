using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picfanc
{
    class ClsSerial
    {

        private Int32 baudidos = 2400;
        private Parity paridad = Parity.None;
        private StopBits bitsParada = StopBits.One;
        private Int32 bitsDatos = 8;
        
        // Opcional ?

        private Handshake enlace = Handshake.None;
        private bool rts = true;

        private SerialPort myPort;

        public string mssg = "";

        public ClsSerial(string nombrePuertos)
        {
            try
            {
                myPort = new SerialPort(nombrePuertos);
                myPort.Parity = paridad;
                myPort.BaudRate = baudidos;
                myPort.DataBits = bitsDatos;
                myPort.StopBits = bitsParada;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SerialPort obtenerPuerto()
        {
            return myPort;
        }


        public bool conectar()
        {
            try
            {
                if (! myPort.IsOpen)
                {
                    myPort.Open();
                }
                else
                {
                    mssg = "Puerto "+ myPort.PortName + " se encuentra abierto...";
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public void cerrar()
        {
            try
            {
                if (myPort.IsOpen)
                {
                    myPort.Close();
                }
                else
                {
                    mssg = "Puerto " + myPort.PortName + " no se cerro, se encuentra cerrado";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RecibidorDatos(SerialDataReceivedEventHandler evento)
        {
            try
            {
                myPort.DataReceived += evento;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public void ErrorDatos(serialdata)


        public void enviarDatos(string dato)
        {
            try
            {
                myPort.Write(dato);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

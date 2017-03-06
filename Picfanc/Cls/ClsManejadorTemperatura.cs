using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Picfanc.Cls
{
    class ClsManejadorTemperatura
    {
        public delegate void MensajeDelegate(string p);
        public event MensajeDelegate Mensaje;

        private int val;

        public ClsManejadorTemperatura()
        {
            val = 0;
        }


        public void run()
        {

        }


        public void aumentoVal()
        {
            val++;
        }

        protected void OnMensaje(string p)
        {
            if (Mensaje != null)
                Mensaje(p);
        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    internal class contacto : persona
    {
        protected string correo;
        protected string numtel;

        public string Correo
        {
            set { correo = value.Replace(" ",""); }
            get { return correo; }

        }
        public string Numtel
        {
            set { numtel = value.Replace(" ", "").Replace(".","").Replace("-",""); }
            get { return numtel; }

        }
        public contacto():base()
        {
            numtel = "";
            correo = "";
        }
        public contacto(string name, string app, string apm, DateTime? fech_nac, string correo, string numtel) : base(name,app,apm,fech_nac) 
            {

            this.correo = correo;
            this.numtel = numtel;
            
        }
        public override string ToString()
        {
            return base.ToString()+" "+numtel+" "+ correo; 
                //name + " " + app + " " + apm; ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace persona
{
    public class persona
    {
        protected  string name;
        protected  string app;
        protected  string apm;
        protected  DateTime? fech_nac;
        protected string a;


        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string App
        {
            set { app = value; }
            get { return app; }
        }
        public string Apm
        {
            set { apm = value; }
            get { return apm; }
        }
        public DateTime? Fech
        {
            set { fech_nac = value; }
            get { return fech_nac; }
        }
        public int edad
        {
            //get { return DateTime.Parse((DateTime.Today - fech_nac)+"").Year; }
            get { return (DateTime.Today.Year - fech_nac.Value.Year); }
        }
      //  public string rfc
      //  {

      //get {
      //          a = Strings.Mid(app, 1, 2);
      //          a += Strings.Mid(apm, 1, 1);
      //          a += Strings.Mid(name, 1, 1);
      //          a += fech_nac.Value.ToString.
      //          a += Strings.Mid(fech_nac, 4, 2);
      //          a += Strings.Mid(fech_nac, 1, 2);
      //          return a; }
      //  }
        public persona()
        {
            name = "";
            app = "";
            apm = "";
            fech_nac = null;
        }

        public persona(string name, string app, string apm, DateTime? fech_nac)
        {
            this.Name = name;
            this.App = app;
            this.Apm = apm;
            this.fech_nac = fech_nac;
            
            
        }

        public override string ToString()
        {
            return name + " " + app + " " + apm;
        }

        //public string calcrfc()
        //{
        //    a = Strings.Mid(app, 1, 2);
        //    a += Strings.Mid(apm, 1, 1);
        //    a += Strings.Mid(name, 1, 1);
        //    a += Strings.Mid(fech_nac, 9, 2);
        //    a += Strings.Mid(fech_nac, 4, 2);
        //    a += Strings.Mid(fech_nac, 1, 2);
        //    return a;
        //}
    }
    
   

}

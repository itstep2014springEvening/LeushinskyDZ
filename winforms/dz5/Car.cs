using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz5
{
   public class Car : Button
    {
        public string CarNumber{get; set;}
        
        public void CarFinish()
        {
            if (CarFinished!=null)
            CarFinished();
        }
        public delegate void Finish();
        public event Finish CarFinished; 
       
    }
}

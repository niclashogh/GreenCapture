using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GreenCapture.Models
{
    public class Frame
    {
        #region Variables & Properties
        public double Width { get; private set; }
        public double Height { get; private set; }
        
        //Color
        #endregion

        #region Constructor
        public Frame(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        #endregion
    }
}

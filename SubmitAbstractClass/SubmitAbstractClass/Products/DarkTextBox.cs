using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubmitAbstractClass.Interfaces;

namespace SubmitAbstractClass.Products
{
   
        public class DarkTextBox : ITextBox
        {
            public void Render() => Console.WriteLine("Rendering Dark TextBox");
        }
    }

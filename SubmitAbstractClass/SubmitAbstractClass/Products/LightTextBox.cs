using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubmitAbstractClass.Interfaces;

namespace SubmitAbstractClass.Products
{
        public class LightTextBox : ITextBox
        {
            public void Render() => Console.WriteLine("Rendering Light TextBox");
        }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubmitAbstractClass.Interfaces;

namespace SubmitAbstractClass.Products
{

                 // Light Mode Components
        public class LightButton : IButton
        {
            public void Render() => Console.WriteLine("Rendering Light Button");
        }
    }

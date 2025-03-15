using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubmitAbstractClass.Interfaces;

namespace SubmitAbstractClass.Products
{
  
         // Dark Mode Components
        public class DarkButton : IButton
        {
            public void Render() => Console.WriteLine("Rendering Dark Button");
        }

    }

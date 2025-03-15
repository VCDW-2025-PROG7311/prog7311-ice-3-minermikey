using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubmitAbstractClass.Interfaces;
using SubmitAbstractClass.Products;

namespace SubmitAbstractClass.Factories
{
        public class LightUIFactory : IUIFactory
{
    public IButton CreateButton() => new LightButton();
    public ITextBox CreateTextBox() => new LightTextBox();
}
}
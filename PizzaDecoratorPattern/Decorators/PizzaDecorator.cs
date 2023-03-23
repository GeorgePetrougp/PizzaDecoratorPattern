using PizzaDecoratorPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecoratorPattern.Decorators
{
    public abstract class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string MakePizza()
        {
            return _pizza.MakePizza();
        }

    }
}

using PizzaDecoratorPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecoratorPattern.Decorators
{
    public class VegPizzaDecorator : PizzaDecorator
    {
        private readonly IPizza _pizza;

        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        private string AddVegetables()
        {
            return ", Vegetables added";
        }

        public override string MakePizza()
        {
            return _pizza.MakePizza() + AddVegetables();
        }
    }
}

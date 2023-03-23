using PizzaDecoratorPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecoratorPattern.Decorators
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        private readonly IPizza _pizza;

        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        private string AddChicken()
        {
            return ", Chicken added";
        }

        public override string MakePizza()
        {
            return _pizza.MakePizza() + AddChicken();
        }
    }
}

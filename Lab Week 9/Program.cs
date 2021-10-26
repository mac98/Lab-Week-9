using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pepepepepperoni_pizza = new Pizza(Pizza.PizzaSize.LARGE, 1, 10, 0);
            Console.WriteLine(pepepepepperoni_pizza.ToString());

            Pizza cheesy_pizza = new Pizza(Pizza.PizzaSize.MEDIUM, 4, 0, 0);
            Console.WriteLine(cheesy_pizza.ToString());

            Pizza pork_pizza = new Pizza(Pizza.PizzaSize.MEDIUM, 0, 3, 6);
            Console.WriteLine(pork_pizza.ToString());

            Pizza non_pizza = new Pizza();
            Console.WriteLine(non_pizza.ToString());

            Console.Read();
        }
    }

    class Pizza
    {
        public enum PizzaSize
        {
            SMALL,
            MEDIUM,
            LARGE
        }

        private PizzaSize pizza_size;
        private int cheese_tops;
        private int pep_tops;
        private int ham_tops;

        public Pizza()
        {
            pizza_size = PizzaSize.SMALL;
            cheese_tops = 0;
            pep_tops = 0;
            ham_tops = 0;
        }

        public Pizza(PizzaSize size, int num_cheese_toppings, int num_pep_toppings, int num_ham_toppings)
        {
            pizza_size = size;
            cheese_tops = num_cheese_toppings;
            pep_tops = num_pep_toppings;
            ham_tops = num_ham_toppings;
        }

        public PizzaSize GetSize()
        {
            return pizza_size;
        }

        public int GetCheeseToppings()
        {
            return cheese_tops;
        }

        public int GetPepToppings()
        {
            return pep_tops;
        }

        public int GetHamToppings()
        {
            return ham_tops;
        }

        public void SetSize(PizzaSize _size)
        {
            pizza_size = _size;
        }

        public void SetCheeseToppings(int num_cheese)
        {
            cheese_tops = num_cheese;
        }

        public void SetPepToppings(int num_pep)
        {
            pep_tops = num_pep;
        }

        public void SetHamToppings(int num_ham)
        {
            ham_tops = num_ham;
        }

        public double CalculateCost()
        {
            double cost = 0;
            if (pizza_size == PizzaSize.SMALL)
            {
                cost = 10;
            }
            else if (pizza_size == PizzaSize.MEDIUM)
            {
                cost = 12;
            }
            else
            {
                cost = 14;
            }
            cost += (cheese_tops + pep_tops + ham_tops) * 2;

            return cost;
        }

        public override string ToString()
        {
            string temp = "One ";

            if (pizza_size == PizzaSize.SMALL)
            {
                temp += "small ";
            }
            else if (pizza_size == PizzaSize.MEDIUM)
            {
                temp += "medium ";
            }
            else
            {
                temp += "large ";
            }

            temp += "pizza ";

            if (cheese_tops > 0 || pep_tops > 0 || ham_tops > 0)
            {
                temp += "with ";
            }
            
            if (cheese_tops > 1)
            {
                temp += cheese_tops + " cheese toppings";
            }
            else if (cheese_tops == 1)
            {
                temp += "a cheese topping";
            }

            if (cheese_tops > 0 && pep_tops > 0 && ham_tops == 0)
            {
                temp += " and ";
            }
            else if (cheese_tops > 0)
            {
                temp += ", ";
            }

            if (pep_tops > 1)
            {
                temp += pep_tops + " pepperoni toppings ";
            }
            else if (pep_tops == 1)
            {
                temp += "a pepperoni topping ";
            }

            if ((cheese_tops > 0 || pep_tops > 0) && ham_tops > 0)
            {
                temp += "and ";
            }

            if (ham_tops > 1)
            {
                temp += ham_tops + " ham toppings ";
            }
            else if (ham_tops == 1)
            {
                temp += "a ham topping ";
            }

            temp += "costing a total of $" + CalculateCost();

            return temp;
        }
    }
}

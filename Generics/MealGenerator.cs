using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    

    // Interface for meal plans
    public interface IMealOption
    {
        string DishName { get; }
        int EnergyValue { get; }
        void DisplayMealInfo();
    }

    // Vegetarian Meal Option
    public class VegetarianDish : IMealOption
    {
        public string DishName { get; private set; }
        public int EnergyValue { get; private set; }

        public VegetarianDish(string dishName, int energyValue)
        {
            DishName = dishName;
            EnergyValue = energyValue;
        }

        public void DisplayMealInfo()
        {
            Console.WriteLine($"[Vegetarian] Dish: {DishName}, Calories: {EnergyValue}");
        }
    }

    // Vegan Meal Option
    public class VeganDish : IMealOption
    {
        public string DishName { get; private set; }
        public int EnergyValue { get; private set; }

        public VeganDish(string dishName, int energyValue)
        {
            DishName = dishName;
            EnergyValue = energyValue;
        }

        public void DisplayMealInfo()
        {
            Console.WriteLine($"[Vegan] Dish: {DishName}, Calories: {EnergyValue}");
        }
    }

    // Keto Meal Option
    public class KetoDish : IMealOption
    {
        public string DishName { get; private set; }
        public int EnergyValue { get; private set; }

        public KetoDish(string dishName, int energyValue)
        {
            DishName = dishName;
            EnergyValue = energyValue;
        }

        public void DisplayMealInfo()
        {
            Console.WriteLine($"[Keto] Dish: {DishName}, Calories: {EnergyValue}");
        }
    }

    // High-Protein Meal Option
    public class ProteinDish : IMealOption
    {
        public string DishName { get; private set; }
        public int EnergyValue { get; private set; }

        public ProteinDish(string dishName, int energyValue)
        {
            DishName = dishName;
            EnergyValue = energyValue;
        }

        public void DisplayMealInfo()
        {
            Console.WriteLine($"[High-Protein] Dish: {DishName}, Calories: {EnergyValue}");
        }
    }

    // Generic Meal Manager with Constraint on IMealOption
    public class MealPlan<T> where T : IMealOption
    {
        private List<T> mealList = new List<T>();

        public void AddDish(T dish)
        {
            mealList.Add(dish);
        }

        public void ShowMealPlan()
        {
            foreach (var dish in mealList)
            {
                dish.DisplayMealInfo();
            }
        }
    }

    // Generic Method to Validate and Generate Meal Plans
    public static class MealPlanner
    {
        public static void CreateMealPlan<T>(MealPlan<T> mealPlan, T dish) where T : IMealOption
        {
            if (dish.EnergyValue < 100)
            {
                Console.WriteLine($"Warning: {dish.DishName} has very low calories!");
            }

            mealPlan.AddDish(dish);
            Console.WriteLine($"Added Dish: {dish.DishName}");
        }
    }

    // Main Program
    class MealGenerator
    {
        static void Main()
        {
            // Create meal plan managers for different diet categories
            MealPlan<VegetarianDish> vegetarianPlan = new MealPlan<VegetarianDish>();
            MealPlan<VeganDish> veganPlan = new MealPlan<VeganDish>();
            MealPlan<KetoDish> ketoPlan = new MealPlan<KetoDish>();
            MealPlan<ProteinDish> proteinPlan = new MealPlan<ProteinDish>();

            // Create meal instances
            VegetarianDish vegMeal1 = new VegetarianDish("Grilled Paneer Salad", 250);
            VeganDish veganMeal1 = new VeganDish("Avocado & Quinoa Bowl", 220);
            KetoDish ketoMeal1 = new KetoDish("Salmon with Avocado", 450);
            ProteinDish proteinMeal1 = new ProteinDish("Steak & Eggs", 650);

            // Generate meal plans using the generic method
            MealPlanner.CreateMealPlan(vegetarianPlan, vegMeal1);
            MealPlanner.CreateMealPlan(veganPlan, veganMeal1);
            MealPlanner.CreateMealPlan(ketoPlan, ketoMeal1);
            MealPlanner.CreateMealPlan(proteinPlan, proteinMeal1);

            // Display all meal plans
            Console.WriteLine("\n--- Vegetarian Meal Plan ---");
            vegetarianPlan.ShowMealPlan();

            Console.WriteLine("\n--- Vegan Meal Plan ---");
            veganPlan.ShowMealPlan();

            Console.WriteLine("\n--- Keto Meal Plan ---");
            ketoPlan.ShowMealPlan();

            Console.WriteLine("\n--- High-Protein Meal Plan ---");
            proteinPlan.ShowMealPlan();
        }
    }

}

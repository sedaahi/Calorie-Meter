namespace Calorie_Meter.Migrations
{
    using Calori_Meter.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Calorie_Meter.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Calorie_Meter.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            if (!context.Categorys.Any())
            {
                context.Categorys.Add(new Calori_Meter.Data.Category()
                {
                    Name = "Breakfast Foods",
                    Foods = new List<Food>()
                    {
                        new Food() { Name = "Egg", Fat = 11, CarboHydrate = 1.1, Protein = 13, Calorie = 155, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Egg.jpg" },
                        new Food() { Name = "Cheese", Fat = 33, CarboHydrate = 1.3, Protein = 25, Calorie = 402, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Cheese.jpg" },
                        new Food() { Name = "Olive", Fat = 11, CarboHydrate = 6, Protein = 0.8, Calorie = 115, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Olive.jpg" },
                        new Food() { Name = "Salami", Fat = 26, CarboHydrate = 2.4, Protein = 22, Calorie = 336, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Salami.jpg" }
                    }
                });

                context.Categorys.Add(new Calori_Meter.Data.Category()
                {
                    Name = "Soups",
                    Foods = new List<Food>()
                    {
                        new Food() { Name = "Tomatoes Soup", Fat = 1.1, CarboHydrate = 8, Protein = 3.7, Calorie = 55, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Tomatoes-Soup.jpg" },
                        new Food() { Name = "Lentil Soup", Fat = 0.3, CarboHydrate = 7, Protein = 0.8, Calorie = 29, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Lentil-Soup.jpg" },
                    }
                });

                context.Categorys.Add(new Calori_Meter.Data.Category()
                {
                    Name = "Red Meat",
                    Foods = new List<Food>()
                    {
                        new Food() { Name = "Tas Kebap", Fat = 27.32, CarboHydrate = 12.98, Protein = 17.96, Calorie = 371, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Tas-Kebap.jpg" },
                        new Food() { Name = "Roast Beef", Fat = 11.34, CarboHydrate = 0, Protein = 29.97, Calorie = 230, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Roast-Beef.jpg" },
                    }
                });

                context.Categorys.Add(new Calori_Meter.Data.Category()
                {
                    Name = "White Meat",
                    Foods = new List<Food>()
                    {
                        new Food() { Name = "Chicken Saute", Fat = 5.12, CarboHydrate = 2.56, Protein = 11.04, Calorie = 101, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Chicken-Saute.jpg" },
                        new Food() { Name = "Chicken Chop", Fat = 8, CarboHydrate = 0, Protein = 19, Calorie = 146, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Chicken-Chop.jpg" },
                        new Food() { Name = "Tuna", Fat = 5.93, CarboHydrate = 0, Protein = 21.62, Calorie = 146, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Tuna.jpg" },
                        new Food() { Name = "Anchovy Pan", Fat = 27.65, CarboHydrate = 14, Protein = 57, Calorie = 180, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Anchovy-Pan.jpg" }
                    }
                });

                context.Categorys.Add(new Calori_Meter.Data.Category()
                {
                    Name = "Olive Oil Foods",
                    Foods = new List<Food>()
                    {
                        new Food() { Name = "Olive Oil Beans", Fat = 7.91, CarboHydrate = 12.85, Protein = 4.92, Calorie = 140, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Olive-Oil-Beans.jpg" },
                        new Food() { Name = "Olive Oil Leaf Wrap", Fat = 6.4, CarboHydrate = 7.6, Protein = 1.3, Calorie = 85, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Olive-Oil-Leaf-Wrap.jpg" },
                    }
                });

                context.Categorys.Add(new Calori_Meter.Data.Category()
                {
                    Name = "Salads",
                    Foods = new List<Food>()
                    {
                        new Food() { Name = "Seosonal Salad ", Fat = 0.66, CarboHydrate = 0.9, Protein = 1.55, Calorie = 25, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Seosonal-Salad.jpg" },
                        new Food() { Name = "Caeser Salad", Fat = 14.17, CarboHydrate = 6.52, Protein = 5.03, Calorie = 170, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Caeser-Salad.jpg" },
                    }
                });

                context.Categorys.Add(new Calori_Meter.Data.Category()
                {
                    Name = "Snacks",
                    Foods = new List<Food>()
                    {
                        new Food() { Name = "Nut", Fat = 61.5, CarboHydrate = 11.4, Protein = 16.6, Calorie = 679, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Nut.jpg" },
                        new Food() { Name = "Apple", Fat = 0.2, CarboHydrate = 14, Protein = 0.3, Calorie = 52, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Apple.jpg" },
                        new Food() { Name = "Fruit Bar", Fat = 26, CarboHydrate = 45, Protein = 11, Calorie = 479, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Fruit-Bar.jpg" },
                        new Food() { Name = "Chocolate", Fat = 31, CarboHydrate = 61, Protein = 4.9, Calorie = 545, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Chocolate.jpg" }
                    }
                });

                context.Categorys.Add(new Calori_Meter.Data.Category()
                {
                    Name = "Drinks",
                    Foods = new List<Food>()
                    {
                        new Food() { Name = "Milk", Fat = 1, CarboHydrate = 5, Protein = 3.4, Calorie = 42, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Milk.jpg" },
                        new Food() { Name = "Fruit Juice", Fat = 0.2, CarboHydrate = 10.9, Protein = 0.6, Calorie = 48, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Orange-Juice.jpg" },
                    }
                });

                context.Categorys.Add(new Calori_Meter.Data.Category()
                {
                    Name = "Bakery Products",
                    Foods = new List<Food>()
                    {
                        new Food() { Name = "Bread", Fat = 3.29, CarboHydrate = 50.61, Protein = 7.64, Calorie = 266, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Bread.jpg" },
                        new Food() { Name = "Simit", Fat = 8, CarboHydrate = 51, Protein = 12, Calorie = 323, ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug","") + "Images\\" + "Simit.jpg" },
                    }
                });
            }
        }
    }
}

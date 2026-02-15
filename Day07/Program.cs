namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyDbContext db = new MyDbContext();
            db.Database.EnsureDeleted();
           
            db.Database.EnsureCreated();

          // Supplier supplier = new Supplier{ Name="Sup1",ContactNumber="0115121581", Email="Manar@gmial.com",};
          // Supplier supplier2 = new Supplier{ Name="Sup2",ContactNumber="0115121581", Email="Manar@gmial.com",};
          // Supplier supplier3 = new Supplier{ Name="Sup3",ContactNumber="0115121581", Email="Manar@gmial.com",};

          //  db.AddRange(supplier,supplier2,supplier3);



          //  CoffeeBean coffee = new CoffeeBean{ Name="caf1",OriginCountry="cou1",RoastLevel=2,PricePerKg=30.03m,SupplierID=1};
          //  CoffeeBean coffee2 = new CoffeeBean{ Name="caf2",OriginCountry="cou1",RoastLevel=2,PricePerKg=30.03m,SupplierID=2};
          //  CoffeeBean coffee3 = new CoffeeBean{ Name="caf3",OriginCountry="cou1",RoastLevel=2,PricePerKg=30.03m,SupplierID=1};
          //  db.AddRange(coffee,coffee2,coffee3);



          //  Batch batch =new Batch {RoastDate = new DateTime(21-1-2026), QuantityKg=50,CoffeeBeanId=1};
          //  Batch batch2 =new Batch {RoastDate = new DateTime(21-2-2026), QuantityKg=150,CoffeeBeanId=2};
          //  Batch batch3 =new Batch {RoastDate = new DateTime(21-3-2026), QuantityKg=100,CoffeeBeanId=1};
          //  db.AddRange (batch,batch2,batch3);



            var SupUpdate = db.Suppliers.FirstOrDefault();
            Console.WriteLine(SupUpdate);


            SupUpdate.Name = "Sup1 Update";


            //db.Suppliers.Remove(SupUpdate);

            Supplier supplier2 = new Supplier { Name = "Sup2", ContactNumber = "0115121581", Email = "Manar@gmial.com", };
            db.Add(supplier2);

            db.SaveChanges();

            var beens = db.CoffeeBeans.Where(b => b.OriginCountry == "cou1").Select(b => b.Name);

            foreach (var been in beens) {

                Console.WriteLine(been);
            }
            ////  var batchUpdate=db.



        }
    }
}

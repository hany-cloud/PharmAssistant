using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PharmAssistant.DAL;
using PharmAssistant.Models.InventoryModel;
using PharmAssistant.Models.PurchaseModel;

namespace PharmAssistant.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext dbContext)
        {
            new List<DrugGenericName>
            {
                new DrugGenericName { ID = 1, GenericName = "ramipril", Description = "ramipril Description" },
                new DrugGenericName { ID = 2, GenericName = "glimepiride", Description = "glimepiride Description" },
                new DrugGenericName { ID = 3, GenericName = "zolpidem", Description = "zolpidem Description" },
                new DrugGenericName { ID = 4, GenericName = "lorazepam", Description = "lorazepam Description" }
            }.ForEach(m => dbContext.DrugGenericNames.Add(m));

            new List<Manufacturer>
            {
                new Manufacturer { ID = 1, ManufacturerName = "Abbott Laboratories", Description = "100 Abbott Park Road Abbott Park, Illinois 60064" },
                new Manufacturer { ID = 2, ManufacturerName = "Daiichi Sankyo", Description = "2 Hilton Court Parsippany, NJ 07054" },
                new Manufacturer { ID = 3, ManufacturerName = "Salix Pharmaceuticals, Inc.", Description = "400 Somerset Corporate Blvd. Bridgewater, NJ 08807" }
            }.ForEach(m => dbContext.Manufacturers.Add(m));

            new List<Item>
            {
                new Item { ID = 1, Name = "Altace", DrugGenericNameID = 1, ManufacturerID = 1, Categeory = Categeory.other, AlertQty = 3},
                new Item { ID = 2, Name = "Zantac", DrugGenericNameID = 1, ManufacturerID = 2, Categeory = Categeory.Drug, AlertQty = 3},
                new Item { ID = 3, Name = "Zestril", DrugGenericNameID = 1, ManufacturerID = 1, Categeory = Categeory.Drug, AlertQty = 3},

                new Item { ID = 4, Name = "Amaryl", DrugGenericNameID = 2, ManufacturerID = 3, Categeory = Categeory.Supplies, AlertQty = 2},
                new Item { ID = 5, Name = "Proventil", DrugGenericNameID = 2, ManufacturerID = 3, Categeory = Categeory.Supplies, AlertQty = 2},

                new Item { ID = 6, Name = "Ambien", DrugGenericNameID = 3, ManufacturerID = 2, Categeory = Categeory.other, AlertQty = 9},
                new Item { ID = 7, Name = "Celexa", DrugGenericNameID = 3, ManufacturerID = 2, Categeory = Categeory.Drug, AlertQty = 2},
                new Item { ID = 8, Name = "Coumadin", DrugGenericNameID = 3, ManufacturerID = 1, Categeory = Categeory.Drug, AlertQty = 2},

                new Item { ID = 9, Name = "Ativan", DrugGenericNameID = 4, ManufacturerID = 1, Categeory = Categeory.Drug, AlertQty = 4}
            }.ForEach(m => dbContext.Items.Add(m));

            //new List<Item>
            //{
            //    new Item { ID = 1, Name = "Altace", DrugGenericName = DrugGenericNames.Single(g => g.ID == 1), Manufacturer = Manufacturers.Single(m => m.ID == 1), Categeory = Categeory.other, AlertQty = 3},
            //    new Item { ID = 2, Name = "Zantac", DrugGenericName = DrugGenericNames.Single(g => g.ID == 1), Manufacturer = Manufacturers.Single(m => m.ID == 2), Categeory = Categeory.Drug, AlertQty = 3},
            //    new Item { ID = 3, Name = "Zestril", DrugGenericName = DrugGenericNames.Single(g => g.ID == 1), Manufacturer = Manufacturers.Single(m => m.ID == 1), Categeory = Categeory.Drug, AlertQty = 3},

            //    new Item { ID = 4, Name = "Amaryl", DrugGenericName = DrugGenericNames.Single(g => g.ID == 2), Manufacturer = Manufacturers.Single(m => m.ID == 3), Categeory = Categeory.Supplies, AlertQty = 2},
            //    new Item { ID = 5, Name = "Proventil", DrugGenericName = DrugGenericNames.Single(g => g.ID == 2), Manufacturer = Manufacturers.Single(m => m.ID == 3), Categeory = Categeory.Supplies, AlertQty = 2},

            //    new Item { ID = 6, Name = "Ambien", DrugGenericName = DrugGenericNames.Single(g => g.ID == 3), Manufacturer = Manufacturers.Single(m => m.ID == 2), Categeory = Categeory.other, AlertQty = 9},
            //    new Item { ID = 7, Name = "Celexa", DrugGenericName = DrugGenericNames.Single(g => g.ID == 3), Manufacturer = Manufacturers.Single(m => m.ID == 2), Categeory = Categeory.Drug, AlertQty = 2},
            //    new Item { ID = 8, Name = "Coumadin", DrugGenericName = DrugGenericNames.Single(g => g.ID == 3), Manufacturer = Manufacturers.Single(m => m.ID == 1), Categeory = Categeory.Drug, AlertQty = 2},

            //    new Item { ID = 9, Name = "Ativan", DrugGenericName = DrugGenericNames.Single(g => g.ID == 4), Manufacturer = Manufacturers.Single(m => m.ID == 1), Categeory = Categeory.Drug, AlertQty = 4}
            //}.ForEach(m => dbContext.Items.Add(m));

            new List<Supplier>
            {
                new Supplier { ID = 1, Name = "Medical Supply Co."},
                new Supplier { ID = 2, Name = "Hospital Warehouse"},
                new Supplier { ID = 3, Name = "AeroCare Home Medical"},
                new Supplier { ID = 4, Name = "After Hours Medical"},
                new Supplier { ID = 5, Name = "Technologies Med Inc."}
            }.ForEach(s => dbContext.Suppliers.Add(s));

        }
    }
}
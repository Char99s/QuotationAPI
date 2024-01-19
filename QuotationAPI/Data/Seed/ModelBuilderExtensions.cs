using Microsoft.EntityFrameworkCore;
using QuotationAPI.Models;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        //Generate Guids before creating data to manage relationships
        List<Guid> guids = new List<Guid>();
        for (int i = 0; i < 50; i++)
        {
            guids.Add(Guid.NewGuid());
        }

        modelBuilder.Entity<PolicyOwner>().HasData(
            new PolicyOwner { Id = guids[0], FirstName = "William", LastName = "Shakespeare" },
            new PolicyOwner { Id = guids[1], FirstName = "Georges", LastName = "White" },
            new PolicyOwner { Id = guids[2], FirstName = "Amelia", LastName = "Taylor" },
            new PolicyOwner { Id = guids[3], FirstName = "Liam", LastName = "Parker" },
            new PolicyOwner { Id = guids[4], FirstName = "Eleanor", LastName = "Jones" },
            new PolicyOwner { Id = guids[5], FirstName = "Alexander", LastName = "Smith" },
            new PolicyOwner { Id = guids[6], FirstName = "Olivia", LastName = "Garcia" },
            new PolicyOwner { Id = guids[7], FirstName = "Noah", LastName = "Brown" },
            new PolicyOwner { Id = guids[8], FirstName = "Maya", LastName = "Miller" },
            new PolicyOwner { Id = guids[9], FirstName = "Ethan", LastName = "Anderson" }
        );

        modelBuilder.Entity<Car>().HasData(
            new Car { Id = guids[10], Make = "Ford", YearOfMake = 2020, QuotationId = guids[30] },
            new Car { Id = guids[11], Make = "Mercedes", YearOfMake = 2016, QuotationId = guids[31] },
            new Car { Id = guids[12], Make = "BMW", YearOfMake = 2012, QuotationId = guids[32] },
            new Car { Id = guids[13], Make = "Audi", YearOfMake = 2013, QuotationId = guids[33] },
            new Car { Id = guids[14], Make = "Dodge", YearOfMake = 2020, QuotationId = guids[34] },
            new Car { Id = guids[15], Make = "Porsche", YearOfMake = 2013, QuotationId = guids[35] },
            new Car { Id = guids[16], Make = "BMW", YearOfMake = 2016, QuotationId = guids[36] },
            new Car { Id = guids[17], Make = "Mercedes", YearOfMake = 2008, QuotationId = guids[37] },
            new Car { Id = guids[18], Make = "Audi", YearOfMake = 2009, QuotationId = guids[38] },
            new Car { Id = guids[19], Make = "Kia", YearOfMake = 2011, QuotationId = guids[39] },
            new Car { Id = guids[20], Make = "Kia", YearOfMake = 2013, QuotationId = guids[40] },
            new Car { Id = guids[21], Make = "Dodge", YearOfMake = 2019, QuotationId = guids[41] },
            new Car { Id = guids[22], Make = "Hyundai", YearOfMake = 2018, QuotationId = guids[42] },
            new Car { Id = guids[23], Make = "Hyundai", YearOfMake = 2022, QuotationId = guids[43] },
            new Car { Id = guids[24], Make = "Ford", YearOfMake = 2023, QuotationId = guids[44] },
            new Car { Id = guids[25], Make = "Kia", YearOfMake = 2023, QuotationId = guids[45] },
            new Car { Id = guids[26], Make = "BMW", YearOfMake = 2010, QuotationId = guids[46] },
            new Car { Id = guids[27], Make = "Chevrolet", YearOfMake = 2022, QuotationId = guids[47] },
            new Car { Id = guids[28], Make = "Porsche", YearOfMake = 2024, QuotationId = guids[48] },
            new Car { Id = guids[29], Make = "Honda", YearOfMake = 2023, QuotationId = guids[49] }
        ); ;

        modelBuilder.Entity<Quotation>().HasData(
            new Quotation { Id = guids[30], PolicyOwnerId = guids[0], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[31], PolicyOwnerId = guids[1], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now },
            new Quotation { Id = guids[32], PolicyOwnerId = guids[3], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now },
            new Quotation { Id = guids[33], PolicyOwnerId = guids[2], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now },
            new Quotation { Id = guids[34], PolicyOwnerId = guids[5], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[35], PolicyOwnerId = guids[4], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now },
            new Quotation { Id = guids[36], PolicyOwnerId = guids[7], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[37], PolicyOwnerId = guids[8], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[38], PolicyOwnerId = guids[4], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[39], PolicyOwnerId = guids[3], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now },
            new Quotation { Id = guids[40], PolicyOwnerId = guids[8], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[41], PolicyOwnerId = guids[9], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now },
            new Quotation { Id = guids[42], PolicyOwnerId = guids[7], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[43], PolicyOwnerId = guids[4], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now },
            new Quotation { Id = guids[44], PolicyOwnerId = guids[3], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[45], PolicyOwnerId = guids[2], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now },
            new Quotation { Id = guids[46], PolicyOwnerId = guids[0], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[47], PolicyOwnerId = guids[6], QuotationStatus = Quotation.QStatus.Purchased, CreationDate = DateTime.Now },
            new Quotation { Id = guids[48], PolicyOwnerId = guids[2], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now },
            new Quotation { Id = guids[49], PolicyOwnerId = guids[6], QuotationStatus = Quotation.QStatus.Draft, CreationDate = DateTime.Now }
        );
    }
}
using EfCore.DbFirst.Scaffold.Models;
using Microsoft.EntityFrameworkCore;

using (var dbContext = new EfCoreDbFirstContext())
{
    var procuts = await dbContext.Products.ToListAsync();

    procuts.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} - Name: {p.Name} Price: {p.Price} Stock: {p.Stock}");
    });
}
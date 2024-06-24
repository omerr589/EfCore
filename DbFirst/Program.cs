
using DbFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var procuts = await _context.Products.ToListAsync(); 

    procuts.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} - Name: {p.Name} Price: {p.Price} Stock: {p.Stock}");
    });
}
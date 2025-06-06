using Calorie_Tracker.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class FoodsService : IDisposable
{
    public readonly AppDbContext _db;

    public FoodsService(AppDbContext db)
    {
        _db = db;
    }

    // CREATE
    public async Task CreateFoodAsync(Food food)
    {
        _db.Foods.Add(food);
        await _db.SaveChangesAsync();
    }

    // READ ALL
    public async Task<List<Food>> GetAllFoodsAsync()
    {
        return await _db.Foods.ToListAsync();
    }

    // READ BY ID
    public async Task<Food> GetFoodByIdAsync(int id)
    {
        return await _db.Foods.FindAsync(id);
    }

    // READ CHUNKS
    public async Task<List<Food>> GetFoodsPagedAsync(int pageNumber, int pageSize)
    {
        return await _db.Foods
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    // FILTERING
    public async Task<List<Food>> GetFoodsFilteredAsync(int minCalorie)
    {
        return await _db.Foods
            .Where(u => u.Calorie >= minCalorie)
            .ToListAsync();
    }

    // SORTING
    public async Task<List<Food>> GetFoodsSortedByNameAsync()
    {
        return await _db.Foods
            .OrderBy(u => u.Name)
            .ToListAsync();
    }

    // UPDATE
    public async Task UpdateFoodAsync(Food updatedFood)
    {
        var existing = await _db.Foods.FindAsync(updatedFood.Id);
        if (existing == null) return;

        existing.Name = updatedFood.Name;
        existing.Calorie = updatedFood.Calorie;
        existing.Fats = updatedFood.Fats;
        existing.Salts = updatedFood.Salts;
        existing.Protein = updatedFood.Protein;
        existing.Caffeine = updatedFood.Caffeine;
        existing.GramsInPortion = updatedFood.GramsInPortion;

        await _db.SaveChangesAsync();
    }

    // DELETE
    public async Task DeleteFoodAsync(int id)
    {
        var food = await _db.Foods.FindAsync(id);
        if (food != null)
        {
            _db.Foods.Remove(food);
            await _db.SaveChangesAsync();
        }
    }
    public void Dispose()
    {
        _db?.Dispose();
    }
}
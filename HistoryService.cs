using Calorie_Tracker.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class HistoryService : IDisposable
{
    public readonly AppDbContext _db;

    public HistoryService(AppDbContext db)
    {
        _db = db;
    }

    // CREATE
    public async Task CreateRecordAsync(HistoryRecord record)
    {
        _db.History.Add(record);
        await _db.SaveChangesAsync();
    }

    // READ ALL
    public async Task<List<HistoryRecord>> GetAllRecordsAsync()
    {
        return await _db.History.ToListAsync();
    }

    // READ BY ID
    public async Task<HistoryRecord> GetRecordByIdAsync(int id)
    {
        return await _db.History.FindAsync(id);
    }

    // FILTERING
    public async Task<List<HistoryRecord>> GetRecordsFilteredAsync(DateTime minDate, DateTime maxDate)
    {
        return await _db.History
            .Where(u => u.DateTime >= minDate)
            .Where(u => u.DateTime <= maxDate)
            .ToListAsync();
    }

    // SORTING
    public async Task<List<HistoryRecord>> GetRecordsSortedByNameAsync()
    {
        return await _db.History
            .OrderBy(u => u.DateTime)
            .ToListAsync();
    }

    // UPDATE
    public async Task UpdateRecordAsync(HistoryRecord updatedRecord)
    {
        var existing = await _db.History.FindAsync(updatedRecord.Id);
        if (existing == null) return;

        existing.FoodId = updatedRecord.FoodId;

        await _db.SaveChangesAsync();
    }

    // DELETE
    public async Task DeleteRecordAsync(int id)
    {
        var record = await _db.History.FindAsync(id);
        if (record != null)
        {
            _db.History.Remove(record);
            await _db.SaveChangesAsync();
        }
    }
    public void Dispose()
    {
        _db?.Dispose();
    }
}
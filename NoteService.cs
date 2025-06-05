using Calorie_Tracker.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class NoteService : IDisposable
{
    private readonly AppDbContext _db;

    public NoteService(AppDbContext db)
    {
        _db = db;
    }

    // CREATE
    public async Task CreateNoteAsync(Note note)
    {
        _db.Notes.Add(note);
        await _db.SaveChangesAsync();
    }

    // READ ALL
    public async Task<List<Note>> GetAllNotesAsync()
    {
        return await _db.Notes.ToListAsync();
    }

    // READ BY ID
    public async Task<Note> GetNoteByIdAsync(int id)
    {
        return await _db.Notes.FindAsync(id);
    }

    // READ CHUNKS
    public async Task<List<Note>> GetNotesPagedAsync(int pageNumber, int pageSize)
    {
        return await _db.Notes
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    // SORTING
    public async Task<List<Note>> GetNotesSortedByDateAsync()
    {
        return await _db.Notes
            .OrderBy(u => u.DateTime)
            .ToListAsync();
    }

    // UPDATE
    public async Task UpdateNoteAsync(Note updatedNote)
    {
        var existing = await _db.Notes.FindAsync(updatedNote.Id);
        if (existing == null) return;

        existing.DateTime = updatedNote.DateTime;
        existing.FoodId = updatedNote.FoodId;
        existing.Noted = updatedNote.Noted;

        await _db.SaveChangesAsync();
    }

    // DELETE
    public async Task DeleteNoteAsync(int id)
    {
        var note = await _db.Notes.FindAsync(id);
        if (note != null)
        {
            _db.Notes.Remove(note);
            await _db.SaveChangesAsync();
        }
    }
    public void Dispose()
    {
        _db?.Dispose();
    }
}
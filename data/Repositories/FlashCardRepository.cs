using System;
using System.Globalization;
using data.DbContexts;
using data.Models;
using data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace data.Repositories;

public class FlashCardRepository : IFlashCardRepository
{
    private readonly MossFlashDbContext _db;
    public FlashCardRepository(MossFlashDbContext db)
    {
        _db = db;
    }

    public async Task<List<FlashCard>> GetFlashCards()
    {
        var num = 0;
        return await _db.FlashCards.Where(card => card.QuizId == num).ToListAsync();
    }
}

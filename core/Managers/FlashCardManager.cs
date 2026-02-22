using System;
using core.Managers.Interfaces;
using data.Models;
using data.Repositories.Interfaces;

namespace core.Managers;

public class FlashCardManager : IFlashCardManager
{
    private readonly IFlashCardRepository _flashCardsRepo;
    public FlashCardManager(IFlashCardRepository flashCardsRepo) 
    {
        _flashCardsRepo = flashCardsRepo;
    }

    public async Task<List<FlashCard>> GetFlashCards()
    {
        return await _flashCardsRepo.GetFlashCards();
    }
}

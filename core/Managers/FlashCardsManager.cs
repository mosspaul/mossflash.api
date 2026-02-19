using System;
using core.Managers.Interfaces;
using data.Repositories.Interfaces;

namespace core.Managers;

public class FlashCardsManager : IFlashCardsManager
{
    private readonly IFlashCardsRepository _flashCardsRepo;
    public FlashCardsManager(IFlashCardsRepository flashCardsRepo) 
    {
        _flashCardsRepo = flashCardsRepo;
    }
}

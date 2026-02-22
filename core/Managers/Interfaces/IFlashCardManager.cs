using System;
using data.Models;

namespace core.Managers.Interfaces;

public interface IFlashCardManager
{
    public Task<List<FlashCard>> GetFlashCards();
}

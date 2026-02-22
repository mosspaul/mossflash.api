using System;
using data.Models;

namespace data.Repositories.Interfaces;

public interface IFlashCardRepository
{
    Task<List<FlashCard>> GetFlashCards();
}

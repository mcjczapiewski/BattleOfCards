﻿
using BattleOfCards.Game;
using System.Collections.Generic;

namespace BattleOfCards.Interfaces
{
    public interface ICardRepo
    {
        List<Card> GetAllCards();
    }
}

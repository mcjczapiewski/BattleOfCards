﻿
using BattleOfCards.Game;
using System.Collections.Generic;

namespace BattleOfCards.Interfaces
{
    public interface ICards
    {
        List<Card> GetAllCards(string fileName);
    }
}

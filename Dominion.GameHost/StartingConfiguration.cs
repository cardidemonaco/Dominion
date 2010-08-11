﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dominion.Cards.Curses;
using Dominion.Cards.Treasure;
using Dominion.Cards.Victory;
using Dominion.Rules;

namespace Dominion.GameHost
{
    public abstract class StartingConfiguration
    {
        private readonly int _numberOfPlayers;

        public StartingConfiguration(int numberOfPlayers)
        {
            if(numberOfPlayers < 1)
                throw new ArgumentException("Number of players must be greater than 0", "numberOfPlayers");

            _numberOfPlayers = numberOfPlayers;
        }

        public virtual void InitializeBank(CardBank bank)
        {
            bank.AddCardPile(Copper);
            bank.AddCardPile(Silver);
            bank.AddCardPile(Gold);
            bank.AddCardPile(Estates);
            bank.AddCardPile(Duchies);
            bank.AddCardPileWhichEndsTheGameWhenEmpty(Provinces);
            bank.AddCardPile(Curses);
        }

        public IEnumerable<Card> CreateStartingDeck()
        {
            return 3.NewCards<Estate>().Concat(7.NewCards<Copper>());
        }

        private int VictoryCardCount
        {
            get { return (Math.Max(0, _numberOfPlayers - 4) * 3) + 12; }
        }

        private CardPile Copper
        {
            get { return new UnlimitedSupplyCardPile(() => new Copper()); }
        }

        private CardPile Silver
        {
            get { return new UnlimitedSupplyCardPile(() => new Silver()); }
        }

        private CardPile Gold
        {
            get { return new UnlimitedSupplyCardPile(() => new Gold()); }
        }

        private CardPile Estates
        {
            get  { return new LimitedSupplyCardPile().WithNewCards<Estate>(VictoryCardCount); }
        }

        private CardPile Duchies
        {
            get { return new LimitedSupplyCardPile().WithNewCards<Duchy>(VictoryCardCount); }
        }

        private CardPile Provinces
        {
            get { return new LimitedSupplyCardPile().WithNewCards<Province>(VictoryCardCount); }
        }

        private CardPile Curses
        {
            get { return new LimitedSupplyCardPile().WithNewCards<Curse>(Math.Max(10, (_numberOfPlayers - 1) * 10)); }
        }
    }
}
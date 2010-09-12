﻿using System;
using System.Text;
using Dominion.Rules.CardTypes;

namespace Dominion.Rules
{
    public interface IGameLog
    {
        void LogTurn(Player player);
        void LogPlay(Player player, ActionCard card);
        void LogBuy(Player player, CardPile pile);

        string Contents { get; }
    }

    public class TextGameLog : IGameLog
    {
        private readonly StringBuilder _builder = new StringBuilder();


        public void LogTurn(Player player)
        {
            _builder.AppendFormat("{0}'s turn has begun.", player.Name);
            _builder.AppendLine();
        }

        public void LogPlay(Player player, ActionCard card)
        {
            _builder.AppendFormat("{0} played a {1}.", player.Name, card.Name);
            _builder.AppendLine();
        }

        public void LogBuy(Player player, CardPile pile)
        {
            _builder.AppendFormat("{0} bought a {1}.", player.Name, pile.Name);
            _builder.AppendLine();
        }

        public string Contents
        {
            get { return _builder.ToString(); }
        }


        
    }
}
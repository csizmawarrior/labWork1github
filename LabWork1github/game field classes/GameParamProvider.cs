﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1github
{
    public class GameParamProvider
    {
        Game game;
        public int GetNear()
        {
            return 2;
        }
        public GameParamProvider(Game g)
        {
            game = g;
        }
        public Board GetBoard()
        {
            return game.Board;
        }
        public Character GetMe()
        {
            return game.ActualCharacter;
        }
        public Player GetPlayer()
        {
            return game.Player;
        }
        public List<Monster> GetMonsters()
        {
            return game.Monsters;
        }
        public List<Trap> GetTraps()
        {
            return game.Traps;
        }
        public int GetRound()
        {
            return game.Round;
        }
        public Monster GetMonster()
        {
            return game.ActualMonster;
        }
        public Trap GetTrap()
        {
            return game.ActualTrap;
        }
        public void NoExecution(int commandCount)
        {
            game.NoExecution = commandCount;
        }
        public void Execute(int commandCount)
        {
            game.ImmediateExecution = commandCount;
        }
        public void Repeat(int commandCount)
        {
            game.Repeat = commandCount;
        }
        public bool OccupiedOrNot(Place p)
        {
            return game.IsOccupied(p);
        }
        public void PlayerCommand()
        {
            game.PlayerCommand();
        }
    }
}

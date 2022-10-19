﻿using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using LabWork1github.static_constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabWork1github.BoardGrammarParser;

namespace LabWork1github
{
    class BoardGrammarVisitor : BoardGrammarBaseVisitor<object>
    {
        public bool ErrorFound { get; set; }

        public string ErrorList { get; set; } = "";

        public override object VisitProgram([NotNull] ProgramContext context)
        {
            VisitStatementList(context.statementList());
            AfterBoardCreationCheck();
            return null;
        }

        public override object VisitStatementList(StatementListContext context)
        {
            return base.VisitStatementList(context);
        }
        public override object VisitStatement([NotNull] StatementContext context)
        {
            return base.VisitStatement(context);
        }
        public override object VisitBoardCreation([NotNull] BoardCreationContext context)
        {
            PlaceContext place = context.place();
            Program.Board.Height = int.Parse(place.x().GetText());
            Program.Board.Width = int.Parse(place.y().GetText());
            if(context.nameDeclaration() != null)
            {
                Program.Board.Name = context.nameDeclaration().ID().GetText();
            }
            return base.VisitBoardCreation(context);
        }

        public override object VisitPlayerPlacement([NotNull] PlayerPlacementContext context)
        {
            PlaceContext place = context.place();
            int xPos = int.Parse(place.x().GetText());
            int yPos = int.Parse(place.y().GetText());
            Program.Board.Player = new Player(new Place(xPos-1, yPos-1), Program.starterHP);
            if (context.nameDeclaration() != null)
                Program.Board.Player.Name = context.nameDeclaration().ID().GetText();
            Program.Characters.Add(Program.Board.Player);
            return base.VisitPlayerPlacement(context);
        }
        public override object VisitMonsterPlacement([NotNull] MonsterPlacementContext context)
        {
            PlaceContext place = context.place();
            int xPos = int.Parse(place.x().GetText());
            int yPos = int.Parse(place.y().GetText());
            string typeName = context.typeName().GetText();
            if (Program.GetCharacterType(typeName) != null && Program.GetCharacterType(typeName) is MonsterType) {
                Monster m = new Monster(Program.starterHP, (MonsterType)Program.GetCharacterType(typeName), new Place(xPos - 1, yPos - 1));

                if(context.nameDeclaration() != null)
                {
                    m.Name = context.nameDeclaration().ID().GetText();
                }
                if (context.partnerDeclaration() != null)
                {
                    m.PartnerName = context.partnerDeclaration().ID().GetText();
                }

                Program.Board.Monsters.Add(m);
                Program.Characters.Add(m);
                return base.VisitMonsterPlacement(context);
            }

            ErrorFound = true;
            ErrorList += ErrorMessages.BoardError.UNDEFINED_MONSTER_TYPE;
            ErrorList += context.GetText() + "\n";
           
            
            return base.VisitMonsterPlacement(context);
        }
        public override object VisitTrapPlacement([NotNull] TrapPlacementContext context)
        {
            PlaceContext place = context.place();
            int xPos = int.Parse(place.x().GetText());
            int yPos = int.Parse(place.y().GetText());
            string typeName = context.typeName().GetText();
            if (Program.GetCharacterType(typeName) != null && Program.GetCharacterType(typeName) is TrapType)
            {
                Trap t = new Trap((TrapType)Program.GetCharacterType(typeName), new Place(xPos - 1, yPos - 1));

                if (context.nameDeclaration() != null)
                {
                    t.Name = context.nameDeclaration().ID().GetText();
                }
                if (context.partnerDeclaration() != null)
                {
                    t.PartnerName = context.partnerDeclaration().ID().GetText();
                }
                
                Program.Board.Traps.Add(t);
                Program.Characters.Add(t);
                return base.VisitTrapPlacement(context);
            }
            ErrorFound = true;
            ErrorList += ErrorMessages.BoardError.UNDEFINED_TRAP_TYPE;
            ErrorList += context.GetText() + "\n";

            return base.VisitTrapPlacement(context);
        }

        private void AfterBoardCreationCheck()
        {
            foreach (Character character in Program.Characters)
            {
                if (character.Place.X > Program.Board.Height || character.Place.Y > Program.Board.Width)
                {
                    Program.Characters.Remove(character);
                    ErrorFound = true;
                    ErrorList += ErrorMessages.GameError.CHARACTER_SPAWNED_OUT_OF_BOUNDS+character.Name;
                }
                if (!character.PartnerName.Equals(""))
                {
                    foreach (Character m in Program.Characters)
                    {
                        if (m.Name.Equals(character.PartnerName))
                        {
                            character.Partner = m;
                            break;
                        }
                    }
                    if (character.Partner == null)
                    {
                        ErrorFound = true;
                        ErrorList += ErrorMessages.GameError.CHARACTER_HAS_NON_EXISTANT_PARTNER + character.Name;
                    }
                }
                foreach (Character c in Program.Characters)
                {
                    if(character is Player)
                            if (c.Place.DirectionTo(character.Place) == Directions.COLLISION && !(c is Player))
                                throw new NullReferenceException(ErrorMessages.GameError.PLAYER_SPAWNED_ON_CHARACTER);
                    if ((c is Trap))
                    {
                        if (c.Place.DirectionTo(character.Place) == Directions.COLLISION && character != c)
                            throw new NullReferenceException(ErrorMessages.GameError.CHARACTER_SPAWNED_ON_TRAP + character.Name);
                        if (character is Player)
                            if (c.Place.DirectionTo(character.Place) == Directions.COLLISION)
                                throw new NullReferenceException(ErrorMessages.GameError.PLAYER_SPAWNED_ON_TRAP);
                    }
                }
            }
        }
    }
}

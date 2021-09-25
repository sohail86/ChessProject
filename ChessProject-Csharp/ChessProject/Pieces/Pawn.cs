using SolarWinds.MSP.Chess.Abstract;
using SolarWinds.MSP.Chess.Enums;
using System;

namespace SolarWinds.MSP.Chess
{
    public class Pawn : ChessPiece
    {
        public Pawn(PieceColor pieceColor)
        {
            PieceColor = pieceColor;
        }

        public override void Move(MovementType movementType, int newX, int newY)
        {
            switch (movementType)
            {
                case MovementType.Move:

                    switch (PieceColor)
                    {
                        case PieceColor.Black:
                            if (YCoordinate - 1 == newY || YCoordinate - 2 == newY && newX == XCoordinate)
                            {
                                XCoordinate = newX;
                                YCoordinate = newY;
                            }
                            break;
                        case PieceColor.White:
                            if (YCoordinate + 1 == newY || YCoordinate + 2 == newY && newX == XCoordinate)
                            {
                                XCoordinate = newX;
                                YCoordinate = newY;
                            }
                            break;
                    }
                    break;
                case MovementType.Capture:
                    // TODO: implement the capture logic
                    break;
            }

        }
        public override string ToString()
        {
            return CurrentPositionAsString();
        }

        protected string CurrentPositionAsString()
        {
            return string.Format("Current X: {1}{0}Current Y: {2}{0}Piece Color: {3}", Environment.NewLine, XCoordinate, YCoordinate, PieceColor);
        }
    }
}

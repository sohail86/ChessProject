using SolarWinds.MSP.Chess.Enums;
using SolarWinds.MSP.Chess.Interfaces;

namespace SolarWinds.MSP.Chess.Abstract
{
    public abstract class ChessPiece : IChessPiece
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public PieceColor PieceColor { get; set; }

        public abstract void Move(MovementType movementType, int newX, int newY);
    }
}

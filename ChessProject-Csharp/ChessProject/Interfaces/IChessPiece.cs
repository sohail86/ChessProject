using SolarWinds.MSP.Chess.Enums;

namespace SolarWinds.MSP.Chess.Interfaces
{
    interface IChessPiece
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public PieceColor PieceColor { get; set; }

        void Move(MovementType movementType, int newX, int newY);
    }
}

using SolarWinds.MSP.Chess.Abstract;
using SolarWinds.MSP.Chess.Enums;

namespace SolarWinds.MSP.Chess.Interfaces
{
    interface IChessBoard
    {
        void Add(ChessPiece piece, int xCoordinate, int yCoordinate, PieceColor pieceColor);
    }
}

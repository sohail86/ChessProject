using SolarWinds.MSP.Chess.Abstract;
using SolarWinds.MSP.Chess.Enums;
using System.Collections.Generic;
using System.Linq;

namespace SolarWinds.MSP.Chess
{
    public class ChessBoard
    {
        public static readonly int MaxBoardWidth = 7;
        public static readonly int MaxBoardHeight = 7;
        private List<ChessPiece> chessPieces;

        public ChessBoard()
        {
            chessPieces = new List<ChessPiece>();
        }

        public void Add(ChessPiece piece, int xCoordinate, int yCoordinate, PieceColor pieceColor)
        {
            var chessPiecesbyTypeAndColor = GetChessPiecesByTypeandColor(piece, pieceColor).ToList();

            if (IsLegalBoardPosition(xCoordinate, yCoordinate) && IsPlaceEmptyForPlacement(xCoordinate, yCoordinate) && chessPiecesbyTypeAndColor.Count() < MaxBoardWidth)
            {

                piece.XCoordinate = xCoordinate;
                piece.YCoordinate = yCoordinate;

                chessPieces.Add(piece);
            }
            else
            {
                piece.XCoordinate = -1;
                piece.YCoordinate = -1;
            }
        }

        public bool IsLegalBoardPosition(int xCoordinate, int yCoordinate)
        {
            return xCoordinate < MaxBoardWidth && xCoordinate >= 0 && yCoordinate < MaxBoardHeight && yCoordinate >= 0;
        }

        private bool IsPlaceEmptyForPlacement(int xCoordinate, int yCoordinate)
        {
            return chessPieces.Find(x => x.XCoordinate == xCoordinate && x.YCoordinate == yCoordinate) == null;
        }

        private IList<ChessPiece> GetChessPiecesByTypeandColor(ChessPiece piece, PieceColor pieceColor)
        {
            return chessPieces.Where(x => x.GetType() == piece.GetType()).Where(x => x.PieceColor == pieceColor).ToList();
        }
    }
}

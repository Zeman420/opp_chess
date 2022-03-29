using System;
using System.Collections.Generic;
using System.Text;

namespace opp_chess
{
    public class figura
    {
        public FigureType Type { get; set; }
        public int MyProperty { get; set; }

        public figura()
        {
            
        }
    }

    //výčtový datový typ-seznam hodnot- interně jsou to hodnoty integer (0)
    public enum FigureType
    {
        Pawn, //pěšec
        Rook, //věž
        Knight, //jezdec
        King, //král
        Gueen, //královna
        Bishop, //střelec
    }
}

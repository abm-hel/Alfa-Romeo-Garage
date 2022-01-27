using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa_Romeo_Garage.ChiffreAffaires
{
    class C_ChiffreAffaires_Piece
    {
        private double? _PRICE;
        private int? _QUANTITY_USED;

        public double? PRICE
        {
            get { return _PRICE; }
            set { _PRICE = value; }
        }

        public int? QUANTITY_USED
        {
            get { return _QUANTITY_USED; }
            set { _QUANTITY_USED = value; }
        }
    }
}

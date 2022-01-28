using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa_Romeo_Garage.FichierTxt
{
    class PieceUsed
    {
        private double? _ID;

        public double? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _NAME;

        public string NAME
        {
            get { return _NAME; }
            set { _NAME = value; }
        }

        private double? _ID_INVOICE;

        public double? ID_INVOICE
        {
            get { return _ID_INVOICE; }
            set { _ID_INVOICE = value; }
        }
    }
}

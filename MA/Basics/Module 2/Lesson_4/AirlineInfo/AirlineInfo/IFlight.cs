﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    interface IFlight
    {
        void Show();
        void Edit(Columns columns, int selectType);
    }
}

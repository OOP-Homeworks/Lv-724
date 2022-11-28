using System;
using System.Collections.Generic;
using System.Text;

namespace HM5
{
    interface IDeveloper
    {
        void Create();
        void Destroy();
        string Tool { set; get; }
    }
}

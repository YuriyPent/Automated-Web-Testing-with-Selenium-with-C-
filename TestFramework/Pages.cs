﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            public static void Goto()
            {
                Browser.Goto(Url);
            }

            public static bool isAt()
            {
                throw new NotImplementedException();
            }
        }
    }
}

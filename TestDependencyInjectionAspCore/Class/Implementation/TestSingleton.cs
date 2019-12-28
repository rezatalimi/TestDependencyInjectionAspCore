﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDependencyInjectionAspCore.Class.Contract;

namespace TestDependencyInjectionAspCore.Class.Implementation
{
    public class TestSingleton : Test, ISingleton
    {
        public TestSingleton() : base ("Singleton")
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSql.Reflection
{
    public static class Default<T>
    {
        public static T Value = default(T);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises
{
    public abstract class Visitor
    {
        public abstract void Visit(File file);
        public abstract void Visit(Directory directory);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamo.Graph.Nodes;

namespace Revit2016.Elements
{
    /// <summary>
    /// </summary>
    public static class Column
    {
        /// <summary>
        /// </summary>
        [NodeCategory("Basilisk.Revit2016")]
        public static object ToBHomBar(List<Revit.Elements.StructuralFraming> columns)
        {
            List<Autodesk.Revit.DB.FamilyInstance> converted = new List<Autodesk.Revit.DB.FamilyInstance>();
            foreach (Revit.Elements.StructuralFraming column in columns)
                converted.Add(column.InternalElement as Autodesk.Revit.DB.FamilyInstance);
            return Revit2016IO.BarIO.RevitColumnsToBHomBars(converted);
        }
    }
}

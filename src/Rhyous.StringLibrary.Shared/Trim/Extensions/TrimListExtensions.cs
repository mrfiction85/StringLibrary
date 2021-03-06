﻿using System.Collections;
using System.Collections.Generic;

namespace Rhyous.StringLibrary
{    /// <summary>
     /// Extensions for trimming strings in ILists.
     /// </summary>
    public static class TrimListExtensions
    {
        public static void TrimList(this IList list, IList<object> objectsBeingTrimmed = null)
        {
            objectsBeingTrimmed = objectsBeingTrimmed ?? new List<object>();
            objectsBeingTrimmed.Add(list);
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                if (item != null && item.GetType() == typeof(string))
                    list[i] = item.ToString().TrimAll();
                else
                    item.TrimStringProperties(objectsBeingTrimmed);
            }
        }
    }
}

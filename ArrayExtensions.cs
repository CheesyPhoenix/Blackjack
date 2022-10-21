using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Removes element from list end returns it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="toRemove">The index of the element to extract</param>
        /// <returns>The element which was removed</returns>
        public static T Extract<T>(this List<T> array, int toRemove)
        {
            T item = array[toRemove];
            array.RemoveAt(toRemove);

            return item;
        }
    }
}

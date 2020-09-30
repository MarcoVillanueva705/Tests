using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Tests_Netframework
    {
        [TestMethod]
        public void Test001()
        {
            //IEnumerable: the ability to go through all of the elements
            //one at a time

            //Listbehaves similar to an array, but list
            //has a dynamic length with type interger
            //List is in the generic collection, generic in
            //the sense that it can be a list of any specified type
            var numbers = new List<int> { 1,2,3,4 };
        }
    }
}

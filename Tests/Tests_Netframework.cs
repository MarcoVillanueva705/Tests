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

            //The thing to confirm using the Assert statement is True.
            //is whether numbers is in fact IEnumerable
            Assert.IsTrue(numbers is IEnumerable<int>);

            //first we need to get the object that makes it possible
            //to go through all the elements.

            //We ask the 'numbers' object to provide us with a new object
            //and enumerator that can enumerate the collection

            //And what is that enumerator?
            //e the object is
            var e = numbers.GetEnumerator();
            //We're saying 'numbers' as a collections is enumberable
            Assert.IsTrue(e is IEnumerator<int>);
        }
    }
}

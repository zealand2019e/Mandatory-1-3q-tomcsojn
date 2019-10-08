using Assignment1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ClassLibraryTest
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void test_Validation()
        {
            Book obj = new Book("NewBook","newAuthor",33,"0123456789123");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void test_Title()
        {
            Book obj = new Book("Ne", "newAuthor", 33, "0123456789123");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void test_Pagenum()
        {
            Book obj = new Book("NewBook", "newAuthor", 10, "0123456789123");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void test_isbn()
        {
            Book obj = new Book("NewBook", "newAuthor", 11, "012345678912");
        }

    }
}

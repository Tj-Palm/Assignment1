using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace UnitTestAssignment1
{
 namespace Assignment1Test
    {
        [TestClass]
        public class UnitTestBook
        {
            private Book _book;

            [TestInitialize]
            public void Init()
            {
                _book = new Book();
            }

            #region ExceptionTest

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestInvalidAuthor()
            {
                
                _book.Author = "a";
            }

            //[TestMethod]
            //[ExpectedException(typeof(ArgumentNullException))]
            //public void TestNullAuthor()
            //{
            //    _book.Author = null;
            //}

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestDataTypeAuthor()
            {
                _book.Author = 2.ToString();
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestInvalidPagesLower()
            {
                _book.Page = 2;
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestInvalidPagesUpper()
            {
                _book.Page = 1001;
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestNegativePages()
            {
                _book.Page = -20;
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestInvalidIsbnLower()
            {
                _book.Isbn13 = "LessThan13";
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestInvalidIsbnUpper()
            {
                _book.Isbn13 = "MoreThan13IsNotLegal";
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestDataTypeIsbn()
            {
                _book.Isbn13 = 12345.ToString();
            }

            #endregion

            #region CorrectTest

            [TestMethod]
            public void TestName()
            {
                //Act
                _book.Author = "Bob";

                //Assert
                Assert.AreEqual("Bob", _book.Author);
            }

            [TestMethod]
            public void TestPage()
            {
                //Act
                _book.Page = 42;

                //Assert
                Assert.AreEqual(42, _book.Page);
            }

            [TestMethod]
            public void TestIsbn13()
            {
                //Act
                _book.Isbn13 = "GEEKSforGEEKS";

                //Assert
                Assert.AreEqual("GEEKSforGEEKS", _book.Isbn13);
            }

            [TestMethod]
            public void TestTitle()
            {
                //Act
                _book.Title = "Title";

                //Assert
                Assert.AreEqual("Title", _book.Title);
            }
            #endregion

        }
    }

}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.StringExtensions;

namespace Tests {
    public class string_tests {
        [Test]
        public void truncate_test() {
            //Arrange
            string input = "Hello";

            //Act
            input = input.Truncate(4);

            //Assert
            Assert.AreEqual("Hell", input);
        }

        [Test]
        public void truncate_test2() {
            //Arrange
            string input = "";

            //Act
            input = input.Truncate(4);

            //Assert
            Assert.AreEqual("", input);
        }

        [Test]
        public void truncate_test3() {
            //Arrange
            string input = "Hello";

            //Act
            input = input.Truncate(40);

            //Assert
            Assert.AreEqual("Hello", input);
        }

        [Test]
        public void truncate_test4() {
            //Arrange
            string input = "Hello";

            //Act
            input = input.Truncate(1, 4);

            //Assert
            Assert.AreEqual("ell", input);
        }

        [Test]
        public void truncate_test5() {
            //Arrange
            string input = "Hello";

            //Act
            input = input.Truncate(1, 40);

            //Assert
            Assert.AreEqual("Hello", input);
        }

        [Test]
        public void with_test() {
            //Arrange
            string input = "Hello {0}";

            //Act
            input = input.With("Joe");

            //Assert
            Assert.AreEqual("Hello Joe", input);
        }
    }
}
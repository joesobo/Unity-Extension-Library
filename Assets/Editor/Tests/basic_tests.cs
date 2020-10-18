using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.BasicExtensions;

namespace Tests {
    public class basic_tests {
        [Test]
        public void swap_int_test() {
            //Arrange
            int x = 1;
            int y = 2;

            //Act
            Swap(ref x, ref y);

            //Assert
            Assert.AreEqual(1, y);
            Assert.AreEqual(2, x);
        }

        [Test]
        public void swap_float_test() {
            //Arrange
            float x = 1.5f;
            float y = 2.5f;

            //Act
            Swap(ref x, ref y);

            //Assert
            Assert.AreEqual(1.5f, y);
            Assert.AreEqual(2.5f, x);
        }

        [Test]
        public void get_direction_test() {
            //Arrange
            Vector3 start = Vector3.zero;
            Vector3 end = new Vector3(1, 0, 0);

            //Act
            Vector3 output = GetDirection(start, end);

            //Assert
            Assert.AreEqual(1, output.x, 1);
            Assert.AreEqual(0, output.y, 1);
            Assert.AreEqual(0, output.z, 1);
        }

        [Test]
        public void get_direction_test2() {
            //Arrange
            Vector3 start = new Vector3(1, 0, 1);
            Vector3 end = new Vector3(5, 0, 5);

            //Act
            Vector3 output = GetDirection(start, end);

            //Assert
            Assert.AreEqual(0.7f, output.x, 5);
            Assert.AreEqual(0, output.y, 5);
            Assert.AreEqual(0.7f, output.z, 5);
        }
    }
}
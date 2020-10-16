using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.BasicExtensions;

namespace Tests
{
    public class basic_tests
    {
        [Test]
        public void swap_int_test() {
            //Assume
            int x = 1;
            int y = 2;

            //Act
            Swap(ref x, ref y);
            
            //Assert
            Assert.AreEqual(y, 1);
            Assert.AreEqual(x, 2);
        }

        [Test]
        public void swap_float_test() {
            //Assume
            float x = 1.5f;
            float y = 2.5f;

            //Act
            Swap(ref x, ref y);
            
            //Assert
            Assert.AreEqual(y, 1.5f);
            Assert.AreEqual(x, 2.5f);
        }

        [Test]
        public void get_direction_test() {
            //Assume
            Vector3 start = Vector3.zero;
            Vector3 end = new Vector3(1, 0, 0);

            //Act
            Vector3 output = GetDirection(start, end);
            
            //Assert
            Assert.AreEqual(output, new Vector3(1, 0, 0));
        }

        [Test]
        public void get_direction_test2() {
            //Assume
            Vector3 start = new Vector3(1, 0, 1);
            Vector3 end = new Vector3(5, 0, 5);

            //Act
            Vector3 output = GetDirection(start, end);
            
            //Assert
            Assert.AreEqual(output, new Vector3(0.7f, 0, 0.7f), 5);
            Assert.AreEqual(0.7f, output.x, 5);
            Assert.AreEqual(0, output.y, 5);
            Assert.AreEqual(0.7f, output.z, 5);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions._3DExtensions;

namespace Tests {
    public class _3D_tests {
        [Test]
        public void is_inside_radius_test() {
            //Arrange
            Vector3 input = Vector3.one;
            Vector3 origin = Vector3.zero;

            //Act
            bool result = input.IsInsideRadius(origin, 2);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void is_inside_radius_test2() {
            //Arrange
            Vector3 input = Vector3.one * 2;
            Vector3 origin = Vector3.one;

            //Act
            bool result = input.IsInsideRadius(origin, 2);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void not_inside_radius_test() {
            //Arrange
            Vector3 input = Vector3.one * 5;
            Vector3 origin = Vector3.zero;

            //Act
            bool result = input.IsInsideRadius(origin, 2);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void random_position_test() {
            //Arrange
            Random.seed = 0;

            //Act
            Vector3 result = RandomPosition(5);

            //Assert
            Assert.AreEqual(-4.3f, result.x, 1);
            Assert.AreEqual(2.5f, result.y, 1);
            Assert.AreEqual(-0.8f, result.z, 1);
        }

        [Test]
        public void random_position_between_radii_test() {
            //Arrange
            Random.seed = 0;

            //Act
            Vector3 result = RandomPositionBetweenRadii(5, 10);

            //Assert
            Assert.AreEqual(-3.2f, result.x, 1);
            Assert.AreEqual(6.2f, result.y, 1);
            Assert.AreEqual(-1.2f, result.z, 1);
        }
    
        [Test]
        public void set_x_test() {
            //Arrange
            Vector3 input = Vector3.zero;

            //Act
            input = input.SetX(1);

            //Assert
            Assert.AreEqual(1, input.x);
            Assert.AreEqual(0, input.y);
            Assert.AreEqual(0, input.z);
        }

        [Test]
        public void set_y_test() {
            //Arrange
            Vector3 input = Vector3.zero;

            //Act
            input = input.SetY(1);

            //Assert
            Assert.AreEqual(0, input.x);
            Assert.AreEqual(1, input.y);
            Assert.AreEqual(0, input.z);
        }

        [Test]
        public void set_z_test() {
            //Arrange
            Vector3 input = Vector3.zero;

            //Act
            input = input.SetZ(1);

            //Assert
            Assert.AreEqual(0, input.x);
            Assert.AreEqual(0, input.y);
            Assert.AreEqual(1, input.z);
        }

        [Test]
        public void add_x_test() {
            //Arrange
            Vector3 input = Vector3.one;

            //Act
            input = input.AddX(1);

            //Assert
            Assert.AreEqual(2, input.x);
            Assert.AreEqual(1, input.y);
            Assert.AreEqual(1, input.z);
        }

        [Test]
        public void add_y_test() {
            //Arrange
            Vector3 input = Vector3.one;

            //Act
            input = input.AddY(1);

            //Assert
            Assert.AreEqual(1, input.x);
            Assert.AreEqual(2, input.y);
            Assert.AreEqual(1, input.z);
        }

        [Test]
        public void add_z_test() {
            //Arrange
            Vector3 input = Vector3.one;

            //Act
            input = input.AddZ(1);

            //Assert
            Assert.AreEqual(1, input.x);
            Assert.AreEqual(1, input.y);
            Assert.AreEqual(2, input.z);
        }
    }
}
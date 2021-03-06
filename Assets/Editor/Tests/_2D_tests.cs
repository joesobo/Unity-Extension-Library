using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions._2DExtensions;

namespace Tests {
    public class _2D_tests {
        [Test]
        public void rotate_90_test() {
            //Arrange
            Vector2 v = new Vector2(1, 0);

            //Act
            Vector2 result = v.Rotate(90);

            //Assert
            Assert.AreEqual(0, result.x, 1);
            Assert.AreEqual(1, result.y, 1);
        }

        [Test]
        public void rotate_45_test() {
            //Arrange
            Vector2 v = new Vector2(1, 0);

            //Act
            Vector2 result = v.Rotate(45);

            //Assert
            Assert.AreEqual(0.7f, result.x, 1);
            Assert.AreEqual(0.7f, result.y, 1);
        }

        [Test]
        public void rotation_normalized_degree_test() {
            //Arrange
            float inputDegrees = 726;

            //Act
            float result = inputDegrees.RotationNormalizedDegree();

            //Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void rotation_normalized_degree_360_test() {
            //Arrange
            float inputDegrees = 360;

            //Act
            inputDegrees.RotationNormalizedDegree();

            //Assert
            Assert.AreEqual(360, inputDegrees);
        }

        [Test]
        public void rotation_normalized_degree_0_test() {
            //Arrange
            float inputDegrees = 0;

            //Act
            inputDegrees.RotationNormalizedDegree();

            //Assert
            Assert.AreEqual(0, inputDegrees);
        }

        [Test]
        public void convert_vector3_test() {
            //Arrange
            Vector2 input = Vector2.one;

            //Act
            Vector3 output = input.ConvertToVector3(1);

            //Assert
            Assert.AreEqual(output.x, 0, 1);
            Assert.AreEqual(output.y, 0, 1);
            Assert.AreEqual(output.z, 1, 1);
        }

        [Test]
        public void set_x_test() {
            //Arrange
            Vector2 input = Vector2.zero;

            //Act
            input = input.SetX(1);

            //Assert
            Assert.AreEqual(1, input.x);
            Assert.AreEqual(0, input.y);
        }

        [Test]
        public void set_y_test() {
            //Arrange
            Vector2 input = Vector2.zero;

            //Act
            input = input.SetY(1);

            //Assert
            Assert.AreEqual(0, input.x);
            Assert.AreEqual(1, input.y);
        }

        [Test]
        public void add_x_test() {
            //Arrange
            Vector2 input = Vector2.one;

            //Act
            input = input.AddX(1);

            //Assert
            Assert.AreEqual(2, input.x);
            Assert.AreEqual(1, input.y);
        }

        [Test]
        public void add_y_test() {
            //Arrange
            Vector2 input = Vector2.one;

            //Act
            input = input.AddY(1);

            //Assert
            Assert.AreEqual(1, input.x);
            Assert.AreEqual(2, input.y);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.NumericalExtensions;

namespace Tests {
    public class numerical_tests {
        [Test]
        public void linear_remap_test() {
            //Arrange
            float input = 0.5f;

            //Act
            float result = input.LinearRemap(0, 1, 0, 100);

            //Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void linear_remap_test2() {
            //Arrange
            float input = 1.5f;

            //Act
            float result = input.LinearRemap(0, 1, 0, 100);

            //Assert
            Assert.AreEqual(150, result);
        }

        [Test]
        public void random_sign_positive_test() {
            //Arrange
            Random.seed = 0;
            int input = 1;

            //Act
            int result = input.WithRandomSign();

            //Assert
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void random_sign_negative_test() {
            //Arrange
            Random.seed = 1;
            int input = 1;

            //Act
            int result = input.WithRandomSign();

            //Assert
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void random_sign_zero_chance_test() {
            //Arrange
            Random.seed = 0;
            int input = 1;

            //Act
            int result = input.WithRandomSign(0);

            //Assert
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void random_50_percent_probability_test() {
            //Arrange
            Random.seed = 0;
            int chance = 50;

            //Act & Assert
            Assert.IsTrue(RandomProbability(chance));
        }

        [Test]
        public void random_50_percent_probability_test2() {
            //Arrange
            Random.seed = 1;
            int chance = 50;

            //Act & Assert
            Assert.IsFalse(RandomProbability(chance));
        }

        [Test]
        public void random_100_percent_probability_test() {
            //Arrange
            int chance = 100;

            //Act & Assert
            Assert.IsTrue(RandomProbability(chance));
        }

        [Test]
        public void random_0_percent_probability_test() {
            //Arrange
            int chance = 0;

            //Act & Assert
            Assert.IsFalse(RandomProbability(chance));
        }

        [Test]
        public void squared_int_test() {
            //Arrange
            int input = 2;

            //Act & Assert
            Assert.AreEqual(4, input.Squared());
        }

        [Test]
        public void squared_float_test() {
            //Arrange
            float input = 2.5f;

            //Act & Assert
            Assert.AreEqual(6.25f, input.Squared(), 1);
        }

        [Test]
        public void cubed_int_test() {
            //Arrange
            int input = 2;

            //Act & Assert
            Assert.AreEqual(8, input.Cubed());
        }

        [Test]
        public void cubed_float_test() {
            //Arrange
            float input = 2.5f;

            //Act & Assert
            Assert.AreEqual(15.625f, input.Cubed(), 1);
        }

        [Test]
        public void divide_int_test() {
            //Arrange
            int denominator = 3;
            int numerator = 10;

            //Act
            Divide(numerator, denominator, out int result, out int remainder);

            //Assert
            Assert.AreEqual(3, result);
            Assert.AreEqual(1, remainder);
        }

        [Test]
        public void divide_float_test() {
            //Arrange
            float denominator = 3.5f;
            float numerator = 12.5f;

            //Act
            Divide(numerator, denominator, out float result, out float remainder);

            //Assert
            Assert.AreEqual(3.57142854f, result);
            Assert.AreEqual(2, remainder);
        }

        [Test]
        public void is_between_test() {
            //Assert
            Assert.IsTrue(5f.IsBetween(0f, 10f));
            Assert.IsFalse(15f.IsBetween(0f, 10f));
            Assert.IsTrue((-5f).IsBetween(-0f, -10f));
        }

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
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine.TestTools;
using static Extensions.ListExtensions;

namespace Tests {
    public class list_tests {
        [Test]
        public void get_random_list_item_test() {
            //Arrange
            UnityEngine.Random.seed = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++) {
                list.Add(i);
            }

            //Act
            int result = list.GetRandomListItem();

            //Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void bad_random_list_item_test() {
            //Arrange
            UnityEngine.Random.seed = 0;
            List<int> list = new List<int>();

            //Act
            try {
                int result = list.GetRandomListItem();
            }
            catch (Exception e) {
                //Assert
                Assert.IsTrue(e != null);
            }
        }

        [Test]
        public void remove_random_list_item_test() {
            //Arrange
            UnityEngine.Random.seed = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++) {
                list.Add(i);
            }

            //Act
            int result = list.RemoveRandomListItem();

            //Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void remove_bad_random_list_item_test() {
            //Arrange
            UnityEngine.Random.seed = 0;
            List<int> list = new List<int>();

            //Act
            try {
                int result = list.RemoveRandomListItem();
            }
            catch (Exception e) {
                //Assert
                Assert.IsTrue(e != null);
            }
        }

        [Test]
        public void shuffle_list_test() {
            //Arrange
            UnityEngine.Random.seed = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++) {
                list.Add(i);
            }
            List<int> expectedResult = new List<int>(new int[] { 6, 8, 0, 7, 4, 2, 5, 3, 1, 9 });

            //Act
            List<int> output = list.Shuffle();

            //Assert
            for (int i = 0; i < output.Count; i++) {
                Assert.AreEqual(expectedResult[i], output[i]);
            }

        }

        [Test]
        public void shuffle_bad_list_test() {
            //Arrange
            UnityEngine.Random.seed = 0;
            List<int> list = new List<int>();

            //Act
            try {
                List<int> result = list.Shuffle();
            }
            catch (Exception e) {
                //Assert
                Assert.IsTrue(e != null);
            }
        }
    }
}
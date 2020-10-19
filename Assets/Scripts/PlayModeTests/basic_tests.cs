using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.BasicExtensions;

namespace Tests {
    public class basic_tests {
        [UnityTest]
        public IEnumerator cube_visible_test() {
            //Arrange
            GameObject cameraObj = new GameObject("Camera");
            Camera camera = cameraObj.AddComponent<Camera>();

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(1, 0, 0);
            MeshRenderer renderer = cube.GetComponent<MeshRenderer>();

            //Act & Assert
            Assert.IsTrue(renderer.isVisibleFrom(camera));

            yield return null;
        }

        [UnityTest]
        public IEnumerator cube_not_visible_test() {
            //Arrange
            GameObject cameraObj = new GameObject("Camera");
            Camera camera = cameraObj.AddComponent<Camera>();

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(-100, 0, 0);
            MeshRenderer renderer = cube.GetComponent<MeshRenderer>();

            //Act & Assert
            Assert.IsFalse(renderer.isVisibleFrom(camera));

            yield return null;
        }

        [UnityTest]
        public IEnumerator destroy_children_test() {
            //Arrange
            GameObject a = new GameObject();
            GameObject b = new GameObject();
            GameObject c = new GameObject();

            b.transform.parent = a.transform;
            c.transform.parent = a.transform;

            Assert.AreEqual(2, a.transform.childCount);

            //Act
            a.DestroyChildren();

            yield return new WaitForSeconds(0.1f);

            //Assert
            Assert.AreEqual(0, a.transform.childCount);
        }

        [UnityTest]
        public IEnumerator get_component_test() {
            //Arrange
            GameObject A = new GameObject();
            A.AddComponent<BoxCollider>();

            //Act & Assert
            Assert.AreEqual(typeof(BoxCollider), A.GetOrAddComponent<BoxCollider>().GetType());

            yield return null;
        }

        [UnityTest]
        public IEnumerator add_component_test() {
            //Arrange
            GameObject A = new GameObject();

            //Act
            A.GetOrAddComponent<BoxCollider>();

            //Assert
            Assert.IsTrue(A.HasComponent<BoxCollider>());

            yield return null;
        }

        [UnityTest]
        public IEnumerator has_component_test() {
            //Arrange
            GameObject A = new GameObject();
            A.AddComponent<BoxCollider>();

            //Act & Assert
            Assert.IsTrue(A.HasComponent<BoxCollider>());

            yield return null;
        }
    
        [UnityTest]
        public IEnumerator set_child_layer_test() {
            //Arrange
            GameObject a = new GameObject();
            GameObject b = new GameObject();
            GameObject c = new GameObject();

            b.transform.parent = a.transform;
            c.transform.parent = a.transform;

            //Act
            a.transform.SetChildLayers("Default");

            yield return new WaitForSeconds(0.1f);

            //Assert
            Assert.AreEqual(0, b.layer);
            Assert.AreEqual(0, c.layer);
        }

        [UnityTest]
        public IEnumerator set_child_layer_recursive_test() {
            //Arrange
            GameObject a = new GameObject();
            GameObject b = new GameObject();
            GameObject c = new GameObject();

            b.transform.parent = a.transform;
            c.transform.parent = b.transform;

            //Act
            a.transform.SetChildLayers("Default", true);

            yield return new WaitForSeconds(0.1f);

            //Assert
            Assert.AreEqual(0, b.layer);
            Assert.AreEqual(0, c.layer);
        }

        [UnityTest]
        public IEnumerator reset_child_transform_test() {
            //Arrange
            GameObject a = new GameObject();
            GameObject b = new GameObject();

            b.transform.parent = a.transform;
            b.transform.position = Vector3.one * 5;
            b.transform.rotation = new Quaternion(45, 45, 45, 45);
            b.transform.localScale = Vector3.one * 5;

            //Act
            a.transform.ResetChildTransform();

            yield return new WaitForSeconds(0.1f);

            //Assert
            Assert.AreEqual(0, b.transform.position.x, 1);
            Assert.AreEqual(0, b.transform.position.y, 1);
            Assert.AreEqual(0, b.transform.position.z, 1);
            Assert.AreEqual(0, b.transform.rotation.x, 1);
            Assert.AreEqual(0, b.transform.rotation.y, 1);
            Assert.AreEqual(0, b.transform.rotation.z, 1);
            Assert.AreEqual(0, b.transform.rotation.w, 1);
            Assert.AreEqual(1, b.transform.localScale.x, 1);
            Assert.AreEqual(1, b.transform.localScale.y, 1);
            Assert.AreEqual(1, b.transform.localScale.z, 1);
        }

        [UnityTest]
        public IEnumerator reset_child_transform_recursive_test() {
            //Arrange
            GameObject a = new GameObject();
            GameObject b = new GameObject();
            GameObject c = new GameObject();

            b.transform.parent = a.transform;
            b.transform.position = Vector3.one * 5;
            b.transform.rotation = new Quaternion(45, 45, 45, 45);
            b.transform.localScale = Vector3.one * 5;

            c.transform.parent = b.transform;
            c.transform.position = Vector3.one * 5;
            c.transform.rotation = new Quaternion(45, 45, 45, 45);
            c.transform.localScale = Vector3.one * 5;

            //Act
            a.transform.ResetChildTransform(true);

            yield return new WaitForSeconds(0.1f);

            //Assert
            Assert.AreEqual(0, b.transform.position.x, 1);
            Assert.AreEqual(0, b.transform.position.y, 1);
            Assert.AreEqual(0, b.transform.position.z, 1);
            Assert.AreEqual(0, b.transform.rotation.x, 1);
            Assert.AreEqual(0, b.transform.rotation.y, 1);
            Assert.AreEqual(0, b.transform.rotation.z, 1);
            Assert.AreEqual(0, b.transform.rotation.w, 1);
            Assert.AreEqual(1, b.transform.localScale.x, 1);
            Assert.AreEqual(1, b.transform.localScale.y, 1);
            Assert.AreEqual(1, b.transform.localScale.z, 1);

            Assert.AreEqual(0, c.transform.position.x, 1);
            Assert.AreEqual(0, c.transform.position.y, 1);
            Assert.AreEqual(0, c.transform.position.z, 1);
            Assert.AreEqual(0, c.transform.rotation.x, 1);
            Assert.AreEqual(0, c.transform.rotation.y, 1);
            Assert.AreEqual(0, c.transform.rotation.z, 1);
            Assert.AreEqual(0, c.transform.rotation.w, 1);
            Assert.AreEqual(1, c.transform.localScale.x, 1);
            Assert.AreEqual(1, c.transform.localScale.y, 1);
            Assert.AreEqual(1, c.transform.localScale.z, 1);
        }
    
        [UnityTest]
        public IEnumerator reset_transform_Test() {
            //Arrange
            GameObject a = new GameObject();

            a.transform.position = Vector3.one * 5;
            a.transform.rotation = new Quaternion(45, 45, 45, 45);
            a.transform.localScale = Vector3.one * 5;

            //Act
            a.transform.ResetTransform();

            yield return new WaitForSeconds(0.1f);

            //Assert
            Assert.AreEqual(0, a.transform.position.x, 1);
            Assert.AreEqual(0, a.transform.position.y, 1);
            Assert.AreEqual(0, a.transform.position.z, 1);
            Assert.AreEqual(0, a.transform.rotation.x, 1);
            Assert.AreEqual(0, a.transform.rotation.y, 1);
            Assert.AreEqual(0, a.transform.rotation.z, 1);
            Assert.AreEqual(0, a.transform.rotation.w, 1);
            Assert.AreEqual(1, a.transform.localScale.x, 1);
            Assert.AreEqual(1, a.transform.localScale.y, 1);
            Assert.AreEqual(1, a.transform.localScale.z, 1);
        }
        
    }
}

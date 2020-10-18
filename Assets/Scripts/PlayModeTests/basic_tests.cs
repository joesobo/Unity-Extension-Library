using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.BasicExtensions;

namespace Tests {
    public class basic_tests {
        [UnityTest]
        //Start
        public IEnumerator is_cube_visible() {
            //Arrange
            Camera camera = new Camera();
            camera.transform.position = Vector3.zero;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(1, 0, 0);
            MeshRenderer renderer = cube.GetComponent<MeshRenderer>();

            //Act & Assert
            Assert.IsTrue(renderer.isVisibleFrom(camera));

            yield return null;
        }
    }
}

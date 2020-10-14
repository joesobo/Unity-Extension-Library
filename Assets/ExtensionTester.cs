using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Extensions.BasicExtensions;
using static Extensions.StringExtensions;

public class ExtensionTester : MonoBehaviour {
    private void OnEnable() {
        RunTests();
    }

    private void RunTests() {
        int x = 5;
        int y = 10;
        Swap(ref x, ref y);
        Assert(x, 10);
        Assert(y, 5);
    }

    private void Assert<T>(T inputValue, T outputValue) {
        Print(inputValue.Equals(outputValue));
    }
}

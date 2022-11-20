using UnityEngine;
using UdonSharp;
using Koyashiro.UdonException;

public class UdonExceptionSample : UdonSharpBehaviour
{
    public void Start()
    {
        Debug.Log(GetStringLength("foo")); // 3
        Debug.Log(GetStringLength("")); // 0
        Debug.Log(GetStringLength(null)); // [UdonException] System.ArgumentNullException: Value cannot be null. (Parameter 'input')
    }

    private static int GetStringLength(string input)
    {
        if (input == null)
        {
            UdonException.ThrowArgumentNullException(nameof(input));
        }

        return input.Length;
    }
}

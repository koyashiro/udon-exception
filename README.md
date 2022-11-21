# UdonException

Exception helper for UdonSharp.

## Example

```cs
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
```

![image](https://user-images.githubusercontent.com/6698252/202893561-c7e73f6b-056a-4c61-9cca-a3e7cdd993dc.png)

## Supported exceptions

- [System.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception)
- [System.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception)
- [System.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)
- [System.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)
- [System.IndexOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception)
- [System.InvalidOperationException](https://learn.microsoft.com/ja-jp/dotnet/api/system.invalidoperationexception)
- [System.KeyNotFoundException](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keynotfoundexception)
- [System.NotImplementedException](https://learn.microsoft.com/ja-jp/dotnet/api/system.notimplementedexception)
- [System.NotSupportedException](https://learn.microsoft.com/ja-jp/dotnet/api/system.notsupportedexception)

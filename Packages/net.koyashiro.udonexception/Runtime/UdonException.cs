using UnityEngine;

namespace Koyashiro.UdonException
{
    public static class UdonException
    {
        private const string COLOR_LOG = "red";
        private const string COLOR_EXCEPTION = "lime";
        private const string COLOR_PARAMETER = "cyan";
        private const string COLOR_ACTUAL_VALUE = "magenta";

        public static void ThrowException()
        {
            var kind = UdonExceptionKind.Exception;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowException(string message)
        {
            var kind = UdonExceptionKind.Exception;
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowArgumentException()
        {
            var kind = UdonExceptionKind.ArgumentException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowArgumentException(string message)
        {
            var kind = UdonExceptionKind.ArgumentException;
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowArgumentException(string message, string paramName)
        {
            var kind = UdonExceptionKind.ArgumentException;
            LogErrorMessage(kind, message, paramName);
            Panic();
        }

        public static void ThrowArgumentNullException()
        {
            var kind = UdonExceptionKind.ArgumentNullException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowArgumentNullException(string paramName)
        {
            var kind = UdonExceptionKind.ArgumentNullException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message, paramName);
            Panic();
        }

        public static void ThrowArgumentNullException(string paramName, string message)
        {
            var kind = UdonExceptionKind.ArgumentNullException;
            LogErrorMessage(kind, message, paramName);
            Panic();
        }

        public static void ThrowArgumentOutOfRangeException()
        {
            var kind = UdonExceptionKind.ArgumentOutOfRangeException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowArgumentOutOfRangeException(string paramName)
        {
            var kind = UdonExceptionKind.ArgumentOutOfRangeException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message, paramName);
            Panic();
        }

        public static void ThrowArgumentOutOfRangeException(string paramName, object actualValue, string message)
        {
            var kind = UdonExceptionKind.ArgumentOutOfRangeException;
            LogErrorMessage(kind, message, paramName, actualValue);
            Panic();
        }

        public static void ThrowArgumentOutOfRangeException(string paramName, string message)
        {
            var kind = UdonExceptionKind.ArgumentOutOfRangeException;
            LogErrorMessage(kind, message, paramName);
            Panic();
        }

        public static void ThrowIndexOutOfRangeException()
        {
            var kind = UdonExceptionKind.IndexOutOfRangeException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowIndexOutOfRangeException(string message)
        {
            var kind = UdonExceptionKind.IndexOutOfRangeException;
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowInvalidOperationException()
        {
            var kind = UdonExceptionKind.InvalidOperationException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowInvalidOperationException(string message)
        {
            var kind = UdonExceptionKind.InvalidOperationException;
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowKeyNotFoundException()
        {
            var kind = UdonExceptionKind.KeyNotFoundException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowKeyNotFoundException(string message)
        {
            var kind = UdonExceptionKind.KeyNotFoundException;
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowNotImplementedException()
        {
            var kind = UdonExceptionKind.NotImplementedException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowNotImplementedException(string message)
        {
            var kind = UdonExceptionKind.NotImplementedException;
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowNotSupportedException()
        {
            var kind = UdonExceptionKind.NotSupportedException;
            var message = GetDefaultExceptionMessage(kind);
            LogErrorMessage(kind, message);
            Panic();
        }

        public static void ThrowNotSupportedException(string message)
        {
            var kind = UdonExceptionKind.NotSupportedException;
            LogErrorMessage(kind, message);
            Panic();
        }

        private static string GetExceptionString(UdonExceptionKind kind)
        {

            switch (kind)
            {
                case UdonExceptionKind.Exception:
                    return "System.Exception";
                case UdonExceptionKind.ArgumentException:
                    return "System.ArgumentException";
                case UdonExceptionKind.ArgumentNullException:
                    return "System.ArgumentNullException";
                case UdonExceptionKind.ArgumentOutOfRangeException:
                    return "System.ArgumentOutOfRangeException";
                case UdonExceptionKind.IndexOutOfRangeException:
                    return "System.IndexOutOfRangeException";
                case UdonExceptionKind.InvalidOperationException:
                    return "System.InvalidOperationException";
                case UdonExceptionKind.KeyNotFoundException:
                    return "System.KeyNotFoundException";
                case UdonExceptionKind.NotImplementedException:
                    return "System.NotImplementedException";
                case UdonExceptionKind.NotSupportedException:
                    return "System.NotSupportedException";
                default:
                    return default;
            }
        }

        private static string GetDefaultExceptionMessage(UdonExceptionKind kind)
        {
            switch (kind)
            {
                case UdonExceptionKind.Exception:
                    return "Exception of type 'System.Exception' was thrown.";
                case UdonExceptionKind.ArgumentException:
                    return "Value does not fall within the expected range.";
                case UdonExceptionKind.ArgumentNullException:
                    return "Value cannot be null.";
                case UdonExceptionKind.ArgumentOutOfRangeException:
                    return "Specified argument was out of the range of valid values.";
                case UdonExceptionKind.IndexOutOfRangeException:
                    return "Index was outside the bounds of the array.";
                case UdonExceptionKind.InvalidOperationException:
                    return "Operation is not valid due to the current state of the object.";
                case UdonExceptionKind.KeyNotFoundException:
                    return "The given key was not present in the dictionary.";
                case UdonExceptionKind.NotImplementedException:
                    return "The method or operation is not implemented.";
                case UdonExceptionKind.NotSupportedException:
                    return "Specified method is not supported.";
                default:
                    return default;
            }
        }

        private static void LogErrorMessage(UdonExceptionKind kind, string message)
        {
            var errorMessage = $"[<color={COLOR_LOG}>UdonException</color>] <color={COLOR_EXCEPTION}>{GetExceptionString(kind)}</color>: {message}";

            // Write error log
            Debug.LogError(errorMessage);
        }

        private static void LogErrorMessage(UdonExceptionKind kind, string message, string paramName)
        {
            var errorMessage = $"[<color={COLOR_LOG}>UdonException</color>] <color={COLOR_EXCEPTION}>{GetExceptionString(kind)}</color>: {message} (Parameter '<color={COLOR_PARAMETER}>{paramName}</color>')";

            // Write error log
            Debug.LogError(errorMessage);
        }

        private static void LogErrorMessage(UdonExceptionKind kind, string message, string paramName, object actualValue)
        {
            var errorMessage = $"[<color={COLOR_LOG}>UdonException</color>] <color={COLOR_EXCEPTION}>{GetExceptionString(kind)}</color>: {message} (Parameter '<color={COLOR_PARAMETER}>{paramName}</color>')\nActual value was <color={COLOR_ACTUAL_VALUE}>{actualValue}</color>.";

            // Write error log
            Debug.LogError(errorMessage);
        }

        private static void Panic()
        {
            // Raise runtime Exception
            ((object)null).ToString();
        }
    }
}

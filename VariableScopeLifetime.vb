Option Explicit On
Option Strict On
Option Compare Binary

Module VariableScopeLifetime

    Dim y As Integer

    Sub Main()
        'TestTwo()
        Dim z As String = "z in main"
        Dim newNumber As Integer
        'TestThree(z)
        'TestFour(z)
        newNumber = 10
        For i = 1 To 2 Step 1
            TestFive(newNumber)
        Next
        'TestFive(newNumber)
        Console.WriteLine(newNumber)

        Console.Read()
    End Sub

    Sub TestFive(ByVal aNumber As Integer)
        Static result As Integer

        result += aNumber
        aNumber = result
        Console.WriteLine(result)
    End Sub



    Sub TestThree(ByVal anyString As String)
        Console.WriteLine(anyString)
        anyString = "not in main"
        Console.WriteLine(anyString)
    End Sub

    Sub TestFour(ByRef anyString As String)
        Console.WriteLine(anyString)
        anyString = "not in main"
        Console.WriteLine(anyString)
    End Sub

    Sub TestOne()
        Dim x As Integer
        y = 7I
        x = 42I
        Console.WriteLine("x=" & CStr(x))
        Console.WriteLine("y=" & CStr(y))
    End Sub

    Sub TestTwo()
        Dim x As Integer
        Console.WriteLine("x=" & CStr(x))
        Console.WriteLine("y=" & CStr(y))
        x = 5I
        y = 4I
        Console.WriteLine("x=" & CStr(x))
        Console.WriteLine("y=" & CStr(y))
        TestOne()
        Console.WriteLine("x=" & CStr(x))
        Console.WriteLine("y=" & CStr(y))
    End Sub




End Module

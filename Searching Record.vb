Module Module1

    Sub Main()
        Dim GRNO, GRVal As Integer
        Dim sName, sClass As String
        Dim sFee As Decimal
        Dim isFeePaid, isFound As Boolean

        GRNO = 0
        GRVal = 0
        sName = ""
        sClass = ""
        sFee = 0
        isFeePaid = False
        isFound = False

        Console.Write("Enter GR number to search for: ") : GRVal = Console.ReadLine()

        FileOpen(1, "C:\filePractice\ABC.txt", OpenMode.Input)
        While Not EOF(1)
            GRNO = LineInput(1)
            Input(1, sName)
            Input(1, sClass)
            Input(1, sFee)
            Input(1, isFeePaid)

            If GRNO = GRVal Then
                isFound = True
                Console.WriteLine("Enter GR No: " & GRNO)
                Console.WriteLine("Enter student name: " & sName)
                Console.WriteLine("Enter student class: " & sClass)
                Console.WriteLine("Enter fee amount: " & sFee)
                Console.WriteLine("Is fee paid? " & isFeePaid)
                Console.WriteLine()
            End If
        End While
        FileClose(1)

        If Not isFound Then
            Console.WriteLine("Record for the GR number " & GRVal & " couldn't be found...")
        End If
        Console.ReadKey()
    End Sub

End Module

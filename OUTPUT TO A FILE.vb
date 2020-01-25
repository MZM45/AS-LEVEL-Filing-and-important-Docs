Module Module1

    Sub Main()
        Dim GRNO As Integer
        Dim sName, sClass As String
        Dim sFee As Decimal
        Dim isFeePaid As Boolean
        Dim more As Char

        GRNO = 0
        sName = ""
        sClass = ""
        sFee = 0
        isFeePaid = False
        more = "N"

        FileOpen(1, "C:\filePractice\ABC.txt", OpenMode.Append)
        Do
            Console.Write("Enter GR No: ") : GRNO = Console.ReadLine
            Console.Write("Enter student name: ") : sName = Console.ReadLine
            Console.Write("Enter student class: ") : sClass = Console.ReadLine
            Console.Write("Enter fee amount: ") : sFee = Console.ReadLine
            Console.Write("Is fee paid? ") : isFeePaid = Console.ReadLine

            WriteLine(1, GRNO)
            WriteLine(1, sName)
            WriteLine(1, sClass)
            WriteLine(1, sFee)
            WriteLine(1, isFeePaid)

            Console.Write("Do you want to enter another record? (Y/N) ")
            more = Console.ReadLine
        Loop Until UCase(more) = "N"
        FileClose(1)
    End Sub

End Module

' *******************
' * Tokenizer Class *
' *******************
' *
' * Written by
' * Neil Everderll
' * on 20121108
' *
' *    This object takes a long string with an optional specified delimiter and breaks the string down into chunks.  The object keeps track of the chunk order
' * and returns them in sequence.  The current position can be moved to the beginning, end, or any place in between.  For an idea on how the moving works, think
' * about the the Access Recordset object and its common functions.  

Public Class Tokenizer
    Private originalString As String = ""
    Private tokens() As String
    Private delimiter As String = ","
    Private currentToken As Integer = 0
    Private isEOF As Boolean = True
    Private isBOF As Boolean = True
    Private initialized As Boolean = False

    Public Sub New()
        StartNewString("")
    End Sub

    Public Sub New(newString As String)
        StartNewString(newString)
    End Sub

    Public Sub New(newString As String, newDelimiter As String)
        StartNewString(newString, newDelimiter)
    End Sub

    Public Sub StartNewString(newString As String, Optional newDelimiter As String = ",")
        Dim delimiters As Integer = 0

        If String.IsNullOrWhiteSpace(newString) Then
            ' no string specified.  Lock up the object
            originalString = ""
            ReDim tokens(0)
            tokens(0) = ""
            currentToken = 0
            isEOF = True
            isBOF = True
            initialized = False
        Else
            ' A string has been given.  Initialize the object
            originalString = newString
            delimiter = newDelimiter
            currentToken = 0
            For a As Integer = 1 To Len(originalString)
                If Mid(originalString, a, Len(delimiter)) = delimiter Then delimiters += 1
            Next

            ReDim tokens(delimiters) : For a = LBound(tokens) To UBound(tokens) : tokens(a) = "" : Next

            For a = 1 To Len(originalString)
                If Mid(originalString, a, Len(delimiter)) = delimiter Then currentToken += 1 Else tokens(currentToken) = tokens(currentToken) + Mid(originalString, a, 1)
            Next

            initialized = True
            MoveFirst()
        End If
    End Sub

    Public Function GetFirst() As String
        If initialized Then Return tokens(0) Else Return ""
    End Function

    Public Function GetLast() As String
        If initialized Then Return tokens(UBound(tokens)) Else Return ""
    End Function

    Public Function GetNext() As String
        Dim token As String = ""
        If Not isEOF And initialized Then
            token = tokens(currentToken)
            currentToken += 1
            isEOF = CheckEOF()
        Else
            token = ""
        End If

        Return token
    End Function

    Public Sub MoveFirst()
        If initialized Then currentToken = 0
        CheckTokens()
    End Sub

    Public Sub MoveLast()
        If initialized Then currentToken = UBound(tokens)
        CheckTokens()
    End Sub

    Public Sub Move(token As Integer)
        If initialized Then
            If token < 0 Then
                MoveFirst()
            ElseIf token > UBound(tokens) Then
                MoveLast()
            Else
                currentToken = token
            End If
        End If
        CheckTokens()
    End Sub

    Private Sub CheckTokens()
        isEOF = CheckEOF()
        isBOF = CheckBOF()
    End Sub

    Private Function CheckEOF() As Boolean
        If currentToken > UBound(tokens) Or Not initialized Then Return True Else Return False
    End Function

    Private Function CheckBOF() As Boolean
        If currentToken < 0 Or Not initialized Then Return True Else Return False
    End Function

    Public Function EOF() As Boolean
        isEOF = CheckEOF()
        Return isEOF
    End Function

    Public Function BOF() As Boolean
        isBOF = CheckBOF()
        Return isBOF
    End Function

End Class

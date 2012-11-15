Imports System.IO

Public Structure Question
    Dim question As String
    Dim answerType As String
    Dim required As Boolean
    Dim answer As String
End Structure

Public Class Interface_1
    Dim QuestionList() As Question
    Dim tokens As Tokenizer
    Dim currentQuestion As Integer

    Private Sub Interface_1_Load() Handles Me.Shown
        tokens = New Tokenizer()
        ReDim QuestionList(-1)

        LoadQuestions()
        currentQuestion = 0
        DisplayQuestion(currentQuestion)
    End Sub

    Private Sub DisplayQuestion(number As Integer)
        lbl_title.Text = "Question " & Format(number + 1) & " of " & Format(UBound(QuestionList) + 1)
        lbl_question.Text = QuestionList(number).question
        txt_answers.Text = QuestionList(number).answer
        If number = LBound(QuestionList) Then cmd_Previous.Enabled = False Else cmd_Previous.Enabled = True
        If number = UBound(QuestionList) Then cmd_Next.Text = "Submit" Else cmd_Next.Text = "Next  ->"
    End Sub

    Private Sub LoadQuestions()
        Dim index As Integer = 0

        Try
            Dim fileReader As New StreamReader("questions.txt")

            Do Until fileReader.Peek = -1
                tokens.StartNewString(fileReader.ReadLine(), "|")
                ReDim Preserve QuestionList(UBound(QuestionList) + 1)
                QuestionList(index).question = tokens.GetNext()
                QuestionList(index).answerType = tokens.GetNext()
                If Trim(UCase(tokens.GetNext())) = "Y" Then QuestionList(index).required = True Else QuestionList(index).required = False
                QuestionList(index).answer = ""
                index += 1
            Loop
        Catch ex As Exception
            MessageBox.Show("Error opening file", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmd_Next_Click(sender As System.Object, e As System.EventArgs) Handles cmd_Next.Click
        ' place holder for error checking
        QuestionList(currentQuestion).answer = txt_answers.Text
        currentQuestion += 1
        CheckQuestion()
        DisplayQuestion(currentQuestion)
    End Sub

    Private Sub cmd_Previous_Click(sender As System.Object, e As System.EventArgs) Handles cmd_Previous.Click
        ' place holder for error checking
        QuestionList(currentQuestion).answer = txt_answers.Text
        currentQuestion -= 1
        CheckQuestion()
        DisplayQuestion(currentQuestion)
    End Sub

    Private Function CheckAnswer(question As Integer) As Boolean
        Dim answer As Boolean = True
        Dim finalAnswer As String = ""
        Dim errorMessage As String = ""
        Dim dummyINT As Integer = 0
        Dim dummyDEC As Decimal = 0.0
        Dim answerLine As String = "YN"


        If String.IsNullOrWhiteSpace(txt_answers.Text) Then
            If QuestionList(question).required Then errorMessage = "Required Value - Cannot be empty"
        Else
            ' The answer isn't empty.  Check the data based on the answer type

            Select Case UCase(QuestionList(question).answerType)
                Case "TXT"
                    ' Text type answer.  Anything can be entered.  Ths is a place holder for adding anything else that could be needed.
                    finalAnswer = txt_answers.Text
                Case "INT"
                    ' Integer type answer.  Check integer conversion.
                    If Not Integer.TryParse(txt_answers.Text, dummyINT) Then
                        errorMessage = "Conversion Error - Only numeric characters allowed"
                    Else
                        finalAnswer = Format(dummyINT)
                    End If
                Case "DBL"
                    ' Decimal type answer.  Check decimal conversion.
                    If Not Decimal.TryParse(txt_answers.Text, dummyDEC) Then
                        errorMessage = "Conversion Error - Only numeric characters allowed"
                    Else
                        finalAnswer = Format(dummyDEC)
                    End If
                Case "CUR"
                    ' Currency Type answer.  Check for and remove "$"
                    If Mid(Trim(txt_answers.Text), 1, 1) = "$" Then QuestionList(question).answer = Mid(Trim(txt_answers.Text), 2)

                    'Check for decimal conversion and force to 2 decimal places
                    If Not Decimal.TryParse(txt_answers.Text, dummyDEC) Then
                        errorMessage = "Conversion Error - Only numeric characters allowed"
                    Else
                        finalAnswer = Format(dummyDEC, "f")
                    End If
                Case "BOOL"
                    finalAnswer = UCase(Mid(Trim(txt_answers.Text), 1, 1))
                    If answerLine.IndexOf(finalAnswer) Then
                        ' need to work on this one.
                    End If
                Case Else
                    MessageBox.Show("Unknown data type specified - " & UCase(QuestionList(question).answerType))
            End Select
        End If

        If Not String.IsNullOrWhiteSpace(errorMessage) Then
            answer = False
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            QuestionList(question).answer = finalAnswer
        End If

        Return answer
    End Function

    Private Sub CheckQuestion()
        If currentQuestion < LBound(QuestionList) Then currentQuestion = LBound(QuestionList)
        If currentQuestion > UBound(QuestionList) Then currentQuestion = UBound(QuestionList)
    End Sub
End Class
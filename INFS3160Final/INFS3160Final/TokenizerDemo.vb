Public Class TokenizerDemo

    Private Sub cmd_Run_Click(sender As System.Object, e As System.EventArgs) Handles cmd_Run.Click
        Dim tokens As New Tokenizer(txt_Message.Text, "|")

        lst_Tokens.Items.Clear()

        Do Until tokens.EOF()
            lst_Tokens.Items.Add(tokens.GetNext())
        Loop
    End Sub
End Class

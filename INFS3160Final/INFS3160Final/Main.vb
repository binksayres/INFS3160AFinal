Imports System.IO

Public Structure batteryInfo
    Dim Name As String
    Dim ID As String
    Dim pack As Integer
    Dim cost As Decimal
    Dim needPerHour As Integer
    Dim rechargable As Boolean
    Dim common As String
    Dim weight As Decimal
    Dim vendorName As String
    Dim vendorID As String
End Structure

Public Class Main
    Dim batteries() As batteryInfo

    Private Sub Main_Load() Handles Me.Load
        ReDim batteries(-1)
    End Sub

    Public Sub ReceiveNewBattery(batInfo As String)
        Dim tokens As Tokenizer = New Tokenizer(batInfo, "|")
        Dim currentBattery As Integer

        AddBlankBattery()
        currentBattery = UBound(batteries)
        With batteries(currentBattery)
            .Name = tokens.GetNext()
            .ID = tokens.GetNext()
            .pack = tokens.GetNext()
            .cost = tokens.GetNext()
            .needPerHour = tokens.GetNext()
            .rechargable = tokens.GetNext()
            .common = tokens.GetNext()
            .weight = tokens.GetNext()
            .vendorName = tokens.GetNext()
            .vendorID = tokens.GetNext()
        End With
    End Sub

    Private Sub AddBlankBattery()
        ReDim Preserve batteries(UBound(batteries) + 1)
        initBatteryEntry(UBound(batteries))
    End Sub

    Private Sub initBatteryEntry(index As Integer)
        With batteries(index)
            .Name = ""
            .ID = ""
            .pack = 0
            .cost = 0.0
            .needPerHour = 0
            .rechargable = False
            .common = ""
            .weight = 0.0
            .vendorName = ""
            .vendorID = ""
        End With
    End Sub

    Private Sub cmd_Tokenizer_Click(sender As System.Object, e As System.EventArgs) Handles cmd_Tokenizer.Click
        TokenizerDemo.Show()
    End Sub

    Private Sub cmd_Interface1_Click(sender As System.Object, e As System.EventArgs) Handles cmd_Interface1.Click
        'Me.Hide()
        Interface_1.Show()
    End Sub
End Class
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Class1


    Shared Function getPreviousYearUnitValue(countryCode As Integer, hsCode As String, transType As Integer) As DataTable

        Class1.ao = 0
        Class1.bo = 0
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("TradeEdit.My.MySettings.TradeStatisticsConnectionString").ConnectionString
        'Dim mon As Integer = Me.ImportDataTableAdapter.MonthForUnitValueImport()
        'Dim year As Integer = Me.ImportDataTableAdapter.YearForUnitValueImport()
        Dim con = New SqlConnection(connectionString)
        'Using con = New SqlConnection("TradeEdit.My.MySettings.TradeStatisticsConnectionString")
        Using cmd = New SqlCommand("select * from yearlyUnitValue where countryCode= @cnt and hsCode=@hs and transType=@transType", con)
            cmd.Parameters.AddWithValue("@cnt", countryCode)
            'hsCode = hsCode.Concat('0')
            cmd.Parameters.AddWithValue("@hs", hsCode)
            'Dim Tyear As Integer = Year.ToString.Substring(2, 2)
            'cmd.Parameters.AddWithValue("@yy", Tyear)
            cmd.Parameters.AddWithValue("@transType", transType)
            Dim da = New SqlDataAdapter(cmd)
            tblUs = New DataTable
            'Dim tblUser As DataTable

            'Dim row As Integer = tblUser
            da.Fill(tblUs)
            If tblUs Is Nothing Then
                'MessageBox.Show("no data")
            End If
            Return tblUs
            con.Close()
            'If tblUser.Rows.Count <> 0 Then
            '    Return tblUser(0)
            'Else
            '    Return Nothing
            'End If
        End Using
        'End Using
    End Function


    Shared Function MonthNametoInteger(ByVal iDay As String) As Integer
        Dim MonName As Integer

        Select Case iDay
            Case "January"
                MonName = 1
            Case "February"
                MonName = 2
            Case "March"
                MonName = 3
            Case "April"
                MonName = 4
            Case "May"
                MonName = 5
            Case "June"
                MonName = 6
            Case "July"
                MonName = 7
            Case "August"
                MonName = 8
            Case "September"
                MonName = 9
            Case "October"
                MonName = 10
            Case "November"
                MonName = 11
            Case "December"
                MonName = 12

            Case Else
                MonName = 0
        End Select
        Return MonName
    End Function
    Shared Function MonthName(ByVal iDayNumber As Integer) As String
        Dim MonName As String

        Select Case iDayNumber
            Case 1
                MonName = "January"
            Case 2
                MonName = "February"
            Case 3
                MonName = "March"
            Case 4
                MonName = "April"
            Case 5
                MonName = "May"
            Case 6
                MonName = "June"
            Case 7
                MonName = "July"
            Case 8
                MonName = "August"
            Case 9
                MonName = "September"
            Case 10
                MonName = "October"
            Case 11
                MonName = "November"
            Case 12
                MonName = "December"

            Case Else
                MonName = "Invalid Day Number"
        End Select
        Return MonName
    End Function
    Public Shared TradeType As String
    Public Shared RoundforFlag As Integer
    Public Shared value As Integer
    Public Shared Month As String
    Public Shared completed As Integer
    Public Shared total As Integer
    Public Shared remain As Integer
    Public Shared Year As Integer
    Public Shared table As String
    Public Shared U_Id As Integer
    Public Shared UnSRec As Integer = 0
    Public Shared UnRec As Integer = 0
    Public Shared SinlgeROundFOrmula As Integer = 0

    Public Shared singleRoundValue As Integer
    Public Shared GetUserID As Integer
    Public Shared U_Name As String
    Public Shared FromRec As Integer

    Public Shared ao As ULong = 0
    Public Shared bo As ULong = 0

    Public Shared From As Integer
    Public Shared GetFromRowIndex As Integer
    Public Shared GetFromVal As Integer
    Public Shared ToRec As Integer
    Public Shared GetToRowIndex As Integer
    Public Shared GetToVal As Integer
    Public Shared cnt As Integer
    Public Shared Password As String
    Public Shared Role As String
    Public Shared BaseValue As String
    Public Shared userCount As Integer
    Public Shared RecNo As Integer
    Public Shared RT As Integer
    Public Shared tT As Integer
    Public Shared Qty As ULong
    Public Shared HS As Integer
    Public Shared RouteCodes As DataTable
    Public Shared previousYear As String = ""
    Public Shared previousMonth As Integer
    Public Shared preYear As Integer
    Public Shared YY As Integer
    Public Shared MM As Integer
    Public Shared BaseMonth As String
    Public Shared BaseYear As Integer
    Public Shared NewbaseMonth As Integer
    Public Shared BaseType As String
    Public Shared hssearchbox As String
    Public Shared CntSearchbox As String
    Public Shared Mon As Integer
    Public Shared BakFrmAssign As Boolean
    Public Shared Asstot As Integer
    Public Shared AssRem As Integer
    Public Shared assAss As Integer
    Public Shared rowindx As Integer
    Public Shared colindx As Integer
    Public Shared Hsrowindx As Integer
    Public Shared Hscolindx As Integer
    Public Shared UserClass As String
    Public Shared beCharaUsr As String
    Public Shared ReAsgn_from As Integer
    Public Shared ReAsgn_To As Integer
    Public Shared oldfrom As Integer
    Public Shared RowNoArray(600) As ULong
    Public Shared ValueArray(600) As ULong
    Public Shared PKRArray(600) As ULong
    Public Shared QtyArray(600) As ULong
    Public Shared formulaflag As Integer = 0
    Public Shared replaceflag As Integer = 0
    Public Shared roundFormulaIndex As Integer = 0
    Public Shared lastSavedIndexflag As Integer = 0
    Public Shared searchcontrol As Integer = 0
    Public Shared ExportSummaryFlag As Integer = 0
    Public Shared ImportSummaryFlag As Integer = 0
    Public Shared HscodeIndex As Integer = 0
    Public Shared IndexPos As Integer = 0
    Public Shared FormulaIndexPos As Integer = 0
    Public Shared Isclear As Integer = 0
    Public Shared HsCodeCP As Integer = 0
    Public Shared SelectedCellCount As Integer
    Public Shared tblUs = New DataTable
End Class

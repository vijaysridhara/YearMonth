'***********************************************************************
'Copyright 2005-2022 Vijay Sridhara

'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at

'http://www.apache.org/licenses/LICENSE-2.0

'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
'***********************************************************************
Public Class YearMonth
    Private _val As Date = Date.Now
    Private _ymtype As YMFormat
    Public Enum YMFormat
        YYYYSepMMM
        YYYYSepMM
        YYYYMMM
        YYYYMM
        YYSepMMM
        YYSepMM
        YYMMM
        YYMM
        MMMSepYYYY
        MMMSepYY
        MMSepYYYY
        MMSepYY
    End Enum
    Public Event ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub DE(ByVal EX As Exception)
        MsgBox(EX.Message, MsgBoxStyle.Critical)
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Property YMType() As YMFormat
        Get
            Return _ymtype
        End Get
        Set(ByVal value As YMFormat)
            _ymtype = value
            YearMonthValue = _val
        End Set
    End Property
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        YearMonthValue = Date.Now
    End Sub
    Public Property YearMonthValue() As String
        Get
            Return ReturnDate()
        End Get
        Set(ByVal value As String)
            Try
                Dim x As Date
                x = value
                _val = "01-" & MonthName(x.Month, True) & "-" & Year(x)
                txtYear.Text = ReturnDate()
                RaiseEvent ValueChanged(Me, New EventArgs)
            Catch ex As Exception
                DE(ex)
            End Try


        End Set
    End Property
    Private _sep As Char = "-"
    Public Property DateSeparator() As Char
        Get
            Return _sep
        End Get
        Set(ByVal value As Char)
            _sep = value
            YearMonthValue = _val
        End Set
    End Property
    Private Function ReturnDate() As String
        Select Case _ymtype
            Case YMFormat.MMMSepYY
                Return Format(_val, "MMM" & _sep & "yy")
            Case YMFormat.MMMSepYYYY
                Return Format(_val, "MMM" & _sep & "yyyy")
            Case YMFormat.MMSepYY
                Return Format(_val, "MM" & _sep & "yy")
            Case YMFormat.MMSepYYYY
                Return Format(_val, "MM" & _sep & "yyyy")
            Case YMFormat.YYMM
                Return Format(_val, "yyMM")
            Case YMFormat.YYMMM
                Return Format(_val, "yyMMM")
            Case YMFormat.YYSepMM
                Return Format(_val, "yy" & _sep & "MM")

            Case YMFormat.YYSepMMM
                Return Format(_val, "yy" & _sep & "MMM")

            Case YMFormat.YYYYMM
                Return Format(_val, "yyyyMM")

            Case YMFormat.YYYYMMM
                Return Format(_val, "yyyyMMM")

            Case YMFormat.YYYYSepMM
                Return Format(_val, "yyyy" & _sep & "MM")

            Case YMFormat.YYYYSepMMM
                Return Format(_val, "yyyy" & _sep & "MMM")

        End Select
    End Function

    Private Sub butLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butLeft.Click
        Try
            YearMonthValue = _val.Day & "-" & MonthName(_val.Month, True) & "-" & _val.Year - 1
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRight.Click
        YearMonthValue = _val.Day & "-" & MonthName(_val.Month, True) & "-" & _val.Year + 1
    End Sub

    Private Sub DecemberToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DecemberToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Dec-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub FebruaryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FebruaryToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Feb-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub FebruaryToolStripMenuItem_DisplayStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FebruaryToolStripMenuItem.DisplayStyleChanged

    End Sub

    Private Sub JanuaryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles JanuaryToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Jan-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub JulyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles JulyToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Jul-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub JuneToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles JuneToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Jun-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub MarchToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MarchToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Mar-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub MayToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MayToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-May-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub NovemberToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NovemberToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Nov-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub OctoberToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OctoberToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Oct-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub SeptemberToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SeptemberToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Sep-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub txtYear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.Click
        Try
            ctxMonth.Show(txtYear, New Point(txtYear.Left, txtYear.Top))
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub txtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.TextChanged

    End Sub

    Private Sub AprilToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AprilToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Apr-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub AugustToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AugustToolStripMenuItem.Click
        Try
            YearMonthValue = _val.Day & "-Aug-" & _val.Year
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub
End Class

Imports System.ComponentModel
Imports System.Runtime.InteropServices

Module Hello
    Sub Main()
        ' Create an instance of the licensed application
        Dim app As frmMain = Nothing
        Try
            ' This will throw a LicenseException if the 
            ' license is invalid... If we get an exception,
            ' "app" will remain null and the Run() method
            ' (below) will not be executed...
            app = New frmMain
        Catch ex As Exception
            ' Catch any error, but especially licensing errors...
            Dim strErr As String = String.Format("Error executing application: '{0}'", ex.Message)
            MessageBox.Show(strErr, "VB RegistryLicensedApplication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If Not app Is Nothing Then
            Application.Run(app)
        End If
    End Sub
End Module

<LicenseProviderAttribute(GetType(RegistryLicenseProvider)), _
 GuidAttribute("2de915e1-df71-3443-9f4d-32259c92ced2")> _
Public Class frmMain
    Inherits System.Windows.Forms.Form

    Private _license As License = Nothing

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Obtain the license
        Me._license = LicenseManager.Validate(GetType(frmMain), Me)

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If

            If Not _license Is Nothing Then
                Me._license.Dispose()
                Me._license = Nothing
            End If

        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This is a licensed application."
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(224, 10)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(311, 44)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Registry Licensed Application"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        ' Just quit...
        Application.Exit()
    End Sub
End Class

Public Class Form1
    Inherits System.Windows.Forms.Form

    ' Note that for an instance of the licensed control to show
    ' up in the editor, the license file *must* be copied to
    ' the appropriate obj subdirectory:
    '
    ' myApp\obj\Release\{lic file}.lic
    '
    ' or
    '
    ' myApp\obj\Debug\{lic file}.lic

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLicColor As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmbLicColor = New LicensedColorComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The licensed ComboBox:"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(296, 32)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "E&xit"
        '
        'ComboBox2
        '
        Me.cmbLicColor.Location = New System.Drawing.Point(8, 32)
        Me.cmbLicColor.Name = "cmbLicColor"
        Me.cmbLicColor.Size = New System.Drawing.Size(280, 21)
        Me.cmbLicColor.TabIndex = 2
        Me.cmbLicColor.Text = "cmbLicColor"
        Me.cmbLicColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbLicColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 69)
        Me.Controls.Add(Me.cmbLicColor)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Licensed Control Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        ' Just quit
        Application.Exit()
    End Sub
End Class

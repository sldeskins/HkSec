Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

<LicenseProviderAttribute(GetType(LicFileLicenseProvider))> _
Public Class LicensedColorComboBox
    Inherits System.Windows.Forms.ComboBox

    Dim _license As License = Nothing

    Public Sub New()
        MyBase.New()
        _license = LicenseManager.Validate(GetType(LicensedColorComboBox), Me)

        FillItems()
        Me.SelectedItem = Items(7) ' Black
        AddHandler Me.DrawItem, New System.Windows.Forms.DrawItemEventHandler(AddressOf Me.DrawItems)
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not _license Is Nothing Then
            _license.Dispose()
            _license = Nothing
        End If

        MyBase.Dispose(disposing)
    End Sub

    Protected Sub FillItems()
        Me.DisplayMember = "Color"

        Me.Items.Add(Brushes.AliceBlue)
        Me.Items.Add(Brushes.AntiqueWhite)
        Me.Items.Add(Brushes.Aqua)
        Me.Items.Add(Brushes.Aquamarine)
        Me.Items.Add(Brushes.Azure)
        Me.Items.Add(Brushes.Beige)
        Me.Items.Add(Brushes.Bisque)
        Me.Items.Add(Brushes.Black)
        Me.Items.Add(Brushes.BlanchedAlmond)
        Me.Items.Add(Brushes.Blue)
        Me.Items.Add(Brushes.BlueViolet)
        Me.Items.Add(Brushes.Brown)
        Me.Items.Add(Brushes.BurlyWood)
        Me.Items.Add(Brushes.CadetBlue)
        Me.Items.Add(Brushes.Chartreuse)
        Me.Items.Add(Brushes.Chocolate)
        Me.Items.Add(Brushes.Coral)
        Me.Items.Add(Brushes.CornflowerBlue)
        Me.Items.Add(Brushes.Cornsilk)
        Me.Items.Add(Brushes.Crimson)
        Me.Items.Add(Brushes.Cyan)
        Me.Items.Add(Brushes.DarkBlue)
        Me.Items.Add(Brushes.DarkCyan)
        Me.Items.Add(Brushes.DarkGoldenrod)
        Me.Items.Add(Brushes.DarkGray)
        Me.Items.Add(Brushes.DarkGreen)
        Me.Items.Add(Brushes.DarkKhaki)
        Me.Items.Add(Brushes.DarkMagenta)
        Me.Items.Add(Brushes.DarkOliveGreen)
        Me.Items.Add(Brushes.DarkOrange)
        Me.Items.Add(Brushes.DarkOrchid)
        Me.Items.Add(Brushes.DarkRed)
        Me.Items.Add(Brushes.DarkSalmon)
        Me.Items.Add(Brushes.DarkSeaGreen)
        Me.Items.Add(Brushes.DarkSlateBlue)
        Me.Items.Add(Brushes.DarkSlateGray)
        Me.Items.Add(Brushes.DarkTurquoise)
        Me.Items.Add(Brushes.DarkViolet)
        Me.Items.Add(Brushes.DeepPink)
        Me.Items.Add(Brushes.DeepSkyBlue)
        Me.Items.Add(Brushes.DimGray)
        Me.Items.Add(Brushes.DodgerBlue)
        Me.Items.Add(Brushes.Firebrick)
        Me.Items.Add(Brushes.FloralWhite)
        Me.Items.Add(Brushes.ForestGreen)
        Me.Items.Add(Brushes.Fuchsia)
        Me.Items.Add(Brushes.Gainsboro)
        Me.Items.Add(Brushes.GhostWhite)
        Me.Items.Add(Brushes.Gold)
        Me.Items.Add(Brushes.Goldenrod)
        Me.Items.Add(Brushes.Gray)
        Me.Items.Add(Brushes.Green)
        Me.Items.Add(Brushes.GreenYellow)
        Me.Items.Add(Brushes.Honeydew)
        Me.Items.Add(Brushes.HotPink)
        Me.Items.Add(Brushes.IndianRed)
        Me.Items.Add(Brushes.Indigo)
        Me.Items.Add(Brushes.Ivory)
        Me.Items.Add(Brushes.Khaki)
        Me.Items.Add(Brushes.Lavender)
        Me.Items.Add(Brushes.LavenderBlush)
        Me.Items.Add(Brushes.LawnGreen)
        Me.Items.Add(Brushes.LemonChiffon)
        Me.Items.Add(Brushes.LightBlue)
        Me.Items.Add(Brushes.LightCoral)
        Me.Items.Add(Brushes.LightCyan)
        Me.Items.Add(Brushes.LightGoldenrodYellow)
        Me.Items.Add(Brushes.LightGray)
        Me.Items.Add(Brushes.LightGreen)
        Me.Items.Add(Brushes.LightPink)
        Me.Items.Add(Brushes.LightSalmon)
        Me.Items.Add(Brushes.LightSeaGreen)
        Me.Items.Add(Brushes.LightSkyBlue)
        Me.Items.Add(Brushes.LightSlateGray)
        Me.Items.Add(Brushes.LightSteelBlue)
        Me.Items.Add(Brushes.LightYellow)
        Me.Items.Add(Brushes.Lime)
        Me.Items.Add(Brushes.LimeGreen)
        Me.Items.Add(Brushes.Linen)
        Me.Items.Add(Brushes.Magenta)
        Me.Items.Add(Brushes.Maroon)
        Me.Items.Add(Brushes.MediumAquamarine)
        Me.Items.Add(Brushes.MediumBlue)
        Me.Items.Add(Brushes.MediumOrchid)
        Me.Items.Add(Brushes.MediumPurple)
        Me.Items.Add(Brushes.MediumSeaGreen)
        Me.Items.Add(Brushes.MediumSlateBlue)
        Me.Items.Add(Brushes.MediumSpringGreen)
        Me.Items.Add(Brushes.MediumTurquoise)
        Me.Items.Add(Brushes.MediumVioletRed)
        Me.Items.Add(Brushes.MidnightBlue)
        Me.Items.Add(Brushes.MintCream)
        Me.Items.Add(Brushes.MistyRose)
        Me.Items.Add(Brushes.Moccasin)
        Me.Items.Add(Brushes.NavajoWhite)
        Me.Items.Add(Brushes.Navy)
        Me.Items.Add(Brushes.OldLace)
        Me.Items.Add(Brushes.Olive)
        Me.Items.Add(Brushes.OliveDrab)
        Me.Items.Add(Brushes.Orange)
        Me.Items.Add(Brushes.OrangeRed)
        Me.Items.Add(Brushes.Orchid)
        Me.Items.Add(Brushes.PaleGoldenrod)
        Me.Items.Add(Brushes.PaleGreen)
        Me.Items.Add(Brushes.PaleTurquoise)
        Me.Items.Add(Brushes.PaleVioletRed)
        Me.Items.Add(Brushes.PapayaWhip)
        Me.Items.Add(Brushes.PeachPuff)
        Me.Items.Add(Brushes.Peru)
        Me.Items.Add(Brushes.Pink)
        Me.Items.Add(Brushes.Plum)
        Me.Items.Add(Brushes.PowderBlue)
        Me.Items.Add(Brushes.Purple)
        Me.Items.Add(Brushes.Red)
        Me.Items.Add(Brushes.RosyBrown)
        Me.Items.Add(Brushes.RoyalBlue)
        Me.Items.Add(Brushes.SaddleBrown)
        Me.Items.Add(Brushes.Salmon)
        Me.Items.Add(Brushes.SandyBrown)
        Me.Items.Add(Brushes.SeaGreen)
        Me.Items.Add(Brushes.SeaShell)
        Me.Items.Add(Brushes.Sienna)
        Me.Items.Add(Brushes.Silver)
        Me.Items.Add(Brushes.SkyBlue)
        Me.Items.Add(Brushes.SlateBlue)
        Me.Items.Add(Brushes.SlateGray)
        Me.Items.Add(Brushes.Snow)
        Me.Items.Add(Brushes.SpringGreen)
        Me.Items.Add(Brushes.SteelBlue)
        Me.Items.Add(Brushes.Tan)
        Me.Items.Add(Brushes.Teal)
        Me.Items.Add(Brushes.Thistle)
        Me.Items.Add(Brushes.Tomato)
        Me.Items.Add(Brushes.Transparent)
        Me.Items.Add(Brushes.Turquoise)
        Me.Items.Add(Brushes.Violet)
        Me.Items.Add(Brushes.Wheat)
        Me.Items.Add(Brushes.White)
        Me.Items.Add(Brushes.WhiteSmoke)
        Me.Items.Add(Brushes.Yellow)
        Me.Items.Add(Brushes.YellowGreen)

    End Sub

    'Protected Overrides Sub RefreshItem(ByVal index As Integer)

    'End Sub

    Private Sub DrawItems(ByVal sender As Object, ByVal die As DrawItemEventArgs)
        ' If we have no index to draw, return.
        If die.Index = -1 Then
            Exit Sub
        End If

        ' The "sender" will be a combobox instance...if none, return.
        If sender Is Nothing Then
            Exit Sub
        End If

        ' Pull the controlling combobox object and prepare to render...
        Dim cmb As ComboBox = CType(sender, ComboBox)
        Dim selectedBrush As SolidBrush = CType(cmb.Items(die.Index), SolidBrush)
        Dim g As Graphics = die.Graphics

        ' If the item is selected, this draws the correct background color
        die.DrawBackground()
        die.DrawFocusRectangle()
        Dim rectPreviewBox As Rectangle = die.Bounds

        ' Draw the color's preview box
        rectPreviewBox.Offset(2, 2)
        rectPreviewBox.Width = 20
        rectPreviewBox.Height -= 4
        g.DrawRectangle(New Pen(die.ForeColor), rectPreviewBox)

        ' Get the appropriate Brush object for the selected color
        ' and fill the preview box.
        rectPreviewBox.Offset(1, 1)
        rectPreviewBox.Width -= 2
        rectPreviewBox.Height -= 2
        g.FillRectangle(selectedBrush, rectPreviewBox)

        ' Draw the name of the color selected. Note we'll clean up the returned
        ' type string. Normally it would come back:
        '
        ' "Color [Black]"
        '
        ' We'll clean it up to produce:
        '
        ' "Black"
        g.DrawString(selectedBrush.Color.ToString().Substring(7, selectedBrush.Color.ToString().Length - 8), Font, New SolidBrush(die.ForeColor), die.Bounds.X + 30, die.Bounds.Y + 1)
    End Sub

End Class

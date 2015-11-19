using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FileLicenseControl
{
	/// <summary>
	/// Summary description for LicensedColorComboBox.
	/// </summary>
	[LicenseProvider(typeof(LicFileLicenseProvider))]
	public class LicensedColorComboBox : System.Windows.Forms.ComboBox
	{
		private License license = null;

		public LicensedColorComboBox()
		{
			license = LicenseManager.Validate(typeof(LicensedColorComboBox), this);
			FillItems();
			base.SelectedItem = base.Items[7]; // Black
			base.DrawItem += new DrawItemEventHandler(this.combo_DrawItem);
		}

		~LicensedColorComboBox() 
		{
			if (license != null) 
			{
				license.Dispose();
				license = null;
			}
		}

		public void FillItems()
		{
			// Fill the combo box with all of the colors in the Colors enumeration
			base.DisplayMember = "Color";

			base.Items.Add(Brushes.AliceBlue);
			base.Items.Add(Brushes.AntiqueWhite);
			base.Items.Add(Brushes.Aqua);
			base.Items.Add(Brushes.Aquamarine);
			base.Items.Add(Brushes.Azure);
			base.Items.Add(Brushes.Beige);
			base.Items.Add(Brushes.Bisque);
			base.Items.Add(Brushes.Black);
			base.Items.Add(Brushes.BlanchedAlmond);
			base.Items.Add(Brushes.Blue);
			base.Items.Add(Brushes.BlueViolet);
			base.Items.Add(Brushes.Brown);
			base.Items.Add(Brushes.BurlyWood);
			base.Items.Add(Brushes.CadetBlue);
			base.Items.Add(Brushes.Chartreuse);
			base.Items.Add(Brushes.Chocolate);
			base.Items.Add(Brushes.Coral);
			base.Items.Add(Brushes.CornflowerBlue);
			base.Items.Add(Brushes.Cornsilk);
			base.Items.Add(Brushes.Crimson);
			base.Items.Add(Brushes.Cyan);
			base.Items.Add(Brushes.DarkBlue);
			base.Items.Add(Brushes.DarkCyan);
			base.Items.Add(Brushes.DarkGoldenrod);
			base.Items.Add(Brushes.DarkGray);
			base.Items.Add(Brushes.DarkGreen);
			base.Items.Add(Brushes.DarkKhaki);
			base.Items.Add(Brushes.DarkMagenta);
			base.Items.Add(Brushes.DarkOliveGreen);
			base.Items.Add(Brushes.DarkOrange);
			base.Items.Add(Brushes.DarkOrchid);
			base.Items.Add(Brushes.DarkRed);
			base.Items.Add(Brushes.DarkSalmon);
			base.Items.Add(Brushes.DarkSeaGreen);
			base.Items.Add(Brushes.DarkSlateBlue);
			base.Items.Add(Brushes.DarkSlateGray);
			base.Items.Add(Brushes.DarkTurquoise);
			base.Items.Add(Brushes.DarkViolet);
			base.Items.Add(Brushes.DeepPink);
			base.Items.Add(Brushes.DeepSkyBlue);
			base.Items.Add(Brushes.DimGray);
			base.Items.Add(Brushes.DodgerBlue);
			base.Items.Add(Brushes.Firebrick);
			base.Items.Add(Brushes.FloralWhite);
			base.Items.Add(Brushes.ForestGreen);
			base.Items.Add(Brushes.Fuchsia);
			base.Items.Add(Brushes.Gainsboro);
			base.Items.Add(Brushes.GhostWhite);
			base.Items.Add(Brushes.Gold);
			base.Items.Add(Brushes.Goldenrod);
			base.Items.Add(Brushes.Gray);
			base.Items.Add(Brushes.Green);
			base.Items.Add(Brushes.GreenYellow);
			base.Items.Add(Brushes.Honeydew);
			base.Items.Add(Brushes.HotPink);
			base.Items.Add(Brushes.IndianRed);
			base.Items.Add(Brushes.Indigo);
			base.Items.Add(Brushes.Ivory);
			base.Items.Add(Brushes.Khaki);
			base.Items.Add(Brushes.Lavender);
			base.Items.Add(Brushes.LavenderBlush);
			base.Items.Add(Brushes.LawnGreen);
			base.Items.Add(Brushes.LemonChiffon);
			base.Items.Add(Brushes.LightBlue);
			base.Items.Add(Brushes.LightCoral);
			base.Items.Add(Brushes.LightCyan);
			base.Items.Add(Brushes.LightGoldenrodYellow);
			base.Items.Add(Brushes.LightGray);
			base.Items.Add(Brushes.LightGreen);
			base.Items.Add(Brushes.LightPink);
			base.Items.Add(Brushes.LightSalmon);
			base.Items.Add(Brushes.LightSeaGreen);
			base.Items.Add(Brushes.LightSkyBlue);
			base.Items.Add(Brushes.LightSlateGray);
			base.Items.Add(Brushes.LightSteelBlue);
			base.Items.Add(Brushes.LightYellow);
			base.Items.Add(Brushes.Lime);
			base.Items.Add(Brushes.LimeGreen);
			base.Items.Add(Brushes.Linen);
			base.Items.Add(Brushes.Magenta);
			base.Items.Add(Brushes.Maroon);
			base.Items.Add(Brushes.MediumAquamarine);
			base.Items.Add(Brushes.MediumBlue);
			base.Items.Add(Brushes.MediumOrchid);
			base.Items.Add(Brushes.MediumPurple);
			base.Items.Add(Brushes.MediumSeaGreen);
			base.Items.Add(Brushes.MediumSlateBlue);
			base.Items.Add(Brushes.MediumSpringGreen);
			base.Items.Add(Brushes.MediumTurquoise);
			base.Items.Add(Brushes.MediumVioletRed);
			base.Items.Add(Brushes.MidnightBlue);
			base.Items.Add(Brushes.MintCream);
			base.Items.Add(Brushes.MistyRose);
			base.Items.Add(Brushes.Moccasin);
			base.Items.Add(Brushes.NavajoWhite);
			base.Items.Add(Brushes.Navy);
			base.Items.Add(Brushes.OldLace);
			base.Items.Add(Brushes.Olive);
			base.Items.Add(Brushes.OliveDrab);
			base.Items.Add(Brushes.Orange);
			base.Items.Add(Brushes.OrangeRed);
			base.Items.Add(Brushes.Orchid);
			base.Items.Add(Brushes.PaleGoldenrod);
			base.Items.Add(Brushes.PaleGreen);
			base.Items.Add(Brushes.PaleTurquoise);
			base.Items.Add(Brushes.PaleVioletRed);
			base.Items.Add(Brushes.PapayaWhip);
			base.Items.Add(Brushes.PeachPuff);
			base.Items.Add(Brushes.Peru);
			base.Items.Add(Brushes.Pink);
			base.Items.Add(Brushes.Plum);
			base.Items.Add(Brushes.PowderBlue);
			base.Items.Add(Brushes.Purple);
			base.Items.Add(Brushes.Red);
			base.Items.Add(Brushes.RosyBrown);
			base.Items.Add(Brushes.RoyalBlue);
			base.Items.Add(Brushes.SaddleBrown);
			base.Items.Add(Brushes.Salmon);
			base.Items.Add(Brushes.SandyBrown);
			base.Items.Add(Brushes.SeaGreen);
			base.Items.Add(Brushes.SeaShell);
			base.Items.Add(Brushes.Sienna);
			base.Items.Add(Brushes.Silver);
			base.Items.Add(Brushes.SkyBlue);
			base.Items.Add(Brushes.SlateBlue);
			base.Items.Add(Brushes.SlateGray);
			base.Items.Add(Brushes.Snow);
			base.Items.Add(Brushes.SpringGreen);
			base.Items.Add(Brushes.SteelBlue);
			base.Items.Add(Brushes.Tan);
			base.Items.Add(Brushes.Teal);
			base.Items.Add(Brushes.Thistle);
			base.Items.Add(Brushes.Tomato);
			base.Items.Add(Brushes.Transparent);
			base.Items.Add(Brushes.Turquoise);
			base.Items.Add(Brushes.Violet);
			base.Items.Add(Brushes.Wheat);
			base.Items.Add(Brushes.White);
			base.Items.Add(Brushes.WhiteSmoke);
			base.Items.Add(Brushes.Yellow);
			base.Items.Add(Brushes.YellowGreen);
		}

		public Color Color
		{
			get { return ((SolidBrush)base.SelectedItem).Color; }
			set
			{
				string strInColor = value.ToString();
				foreach ( SolidBrush myColor in base.Items )
				{
					// Check the string
					if ( String.Compare(strInColor, myColor.Color.ToString()) == 0 )
					{
						// Found it
						base.SelectedItem = myColor;
						break;
					} // if
				} // foreach
			}
		}

		private void combo_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs die)
		{
			// If we have no index to draw, return.
			if ( die.Index == -1 )
			{
				return;
			} // if

			// The "sender" will be a combobox instance...if none, return.
			if ( sender == null )
			{
				return;
			} // if

			// Pull the controlling combobox object and prepare to render...
			ComboBox cmb = (ComboBox)sender;
			SolidBrush selectedBrush = (SolidBrush)cmb.Items[die.Index];
			Graphics g = die.Graphics;

			// If the item is selected, this draws the correct background color
			die.DrawBackground();
			die.DrawFocusRectangle();
			Rectangle rectPreviewBox = die.Bounds;

			// Draw the color's preview box
			rectPreviewBox.Offset(2, 2);
			rectPreviewBox.Width = 20;
			rectPreviewBox.Height -= 4;
			g.DrawRectangle(new Pen(die.ForeColor), rectPreviewBox);

			// Get the appropriate Brush object for the selected color
			// and fill the preview box.
			rectPreviewBox.Offset(1, 1);
			rectPreviewBox.Width -= 2;
			rectPreviewBox.Height -= 2;
			g.FillRectangle(selectedBrush, rectPreviewBox);

			// Draw the name of the color selected. Note we'll clean up the returned
			// type string. Normally it would come back:
			//
			// "Color [Black]"
			//
			// We'll clean it up to produce:
			//
			// "Black"
			g.DrawString(selectedBrush.Color.ToString().Substring(7,selectedBrush.Color.ToString().Length-8), Font, new SolidBrush(die.ForeColor), die.Bounds.X + 30, die.Bounds.Y + 1);
		}
	}
}

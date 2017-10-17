using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_MP_Vehicle_List
{
    public partial class Form_Copy : Form
    {
        public Form_Copy()
        {
            InitializeComponent();
        }

        private void Form_Copy_Load(object sender, EventArgs e)
        {
            int _iterator = 0;
            RichTextBox_Copy.Text = "Array_Vehicles[" + Form_Main.Temp_VL.Count + "] = {\n";

            foreach(Class_Vehicle Vehicle in Form_Main.Temp_VL)
                RichTextBox_Copy.Text += Vehicle.Model_id.ToString() + ((++_iterator == Form_Main.Temp_VL.Count) ? "\n" : ",\n");

            RichTextBox_Copy.Text += "};";
        }

        private void Button_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RichTextBox_Copy.Text);
            RichTextBox_Copy.Focus();
            RichTextBox_Copy.SelectionStart = 0;
            RichTextBox_Copy.SelectionLength = RichTextBox_Copy.Text.Length;
            StatusStrip_Copy.Items.Clear();
            StatusStrip_Copy.Items.Add("Array was successfully copied!");
        }
    }
}

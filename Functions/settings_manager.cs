using EasyHCI.Functions.UI;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHCI.Functions
{
    class settings_manager : IDisposable
    {
        public void Dispose()
        { }




        public void SaveTestSettings(Control[] controls)
        {
            StringBuilder app_settings = new StringBuilder(null);
            StringBuilder control_data = new StringBuilder(null);

            string[] exception_controls = { "test_manual_ammount", "test_manual_count" };

            for (int i = 0; i < controls.Length; ++i)
            {
                // Except few controls
                bool exceptThis = false;
                for (int e_i = 0; e_i < exception_controls.Length; ++e_i)
                {
                    if (controls[i].Name == exception_controls[e_i])
                    {
                        exceptThis = true;
                        break;
                    }
                }
                if (exceptThis)
                    continue;



                control_data.Clear();

                control_data.Append(controls[i].Name + "\\" + controls[i].Text);

                if (controls[i] is MaterialCheckBox)
                    control_data.Append("\\" + ((MaterialCheckBox)controls[i]).Checked.ToString());
                else if (controls[i] is Slider)
                    control_data.Append("\\" + ((Slider)controls[i]).Value.ToString());
                else if (controls[i] is PictureBox)
                    control_data.Append("\\" + new ColorConverter().ConvertToString(controls[i].BackColor));
                else
                    control_data.Append("\\" + "null");

                app_settings.AppendLine(control_data.ToString());

            }







        }

    }
}
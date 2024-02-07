using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Helperi
{
    public class UserControlsHelp
    {
        public static bool PraznoPoljeValidacija(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool IntValidacija(TextBox txt)
        {
            if (!int.TryParse(txt.Text, out int _))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool DoubleValidacija(TextBox txt)
        {
            if (Convert.ToDouble(txt.Text)<50)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool KvotaValidacija(TextBox txt)
        {
            if (Convert.ToDouble(txt.Text) < 1 | Convert.ToDouble(txt.Text) > 10)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool DatumValidacija(TextBox txt)
        {
            if (!DateTime.TryParseExact(txt.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
        public static bool DatumVremeValidacija(TextBox txt)
        {
            if (!DateTime.TryParseExact(txt.Text, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool BoolValidacija(TextBox txt)
        {
            if (!(txt.Text == "True" || txt.Text == "true" || txt.Text == "False" || txt.Text == "false" || txt.Text == "FALSE" || txt.Text == "TRUE"))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
    }
}

using System.Windows.Forms;

namespace projeto_desktop
{
     class Utils
    {
        public static bool temCamposVazio(Form form)
        {
            
            foreach (Control c in form.Controls)
            {
               
                TextBox tbx = c as TextBox;
           
                if (tbx != null && tbx.Text.Trim().Length == 0)
                {
                   
                    return true;
                }
            }
         
            return false;
        }
    }
}
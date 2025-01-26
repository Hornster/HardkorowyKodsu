using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Helpers
{
    public static class ExceptionHelper
    {
        public static void HandleException(Exception ex)
        { 
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

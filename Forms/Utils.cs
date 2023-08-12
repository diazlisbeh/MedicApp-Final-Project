using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    static class Utils
    {
        public static bool Validate(object clas)
        {
            ValidationContext context = new ValidationContext(clas, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(clas, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    MessageBox.Show(result.ErrorMessage, "ValidationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;
           
        }
        
    }
}

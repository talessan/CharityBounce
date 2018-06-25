using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityBounce.Validation
{
    public class LettersOnlyAttribute : RegularExpressionAttribute
    {
        public LettersOnlyAttribute() : base("^[A-Za-z]{3,10}$")
        {

        }
    }
}


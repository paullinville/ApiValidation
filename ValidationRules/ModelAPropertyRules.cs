using ApiTestValidationFilter.Models;
using FFP.Validations;
using System;
using System.Collections.Generic;

namespace ApiTestValidationFilter.ValidationRules
{
    public class ModelAPropertyRules : TypeValidation
    {
        public override IEnumerable<Type> TypeFor
        {
            get
            {
                return new[] { typeof(ModelA) };
            }
        }


    }
}

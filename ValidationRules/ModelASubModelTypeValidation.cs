using ApiTestValidationFilter.Models;
using Validations;
using System;
using System.Collections.Generic;
namespace ApiTestValidationFilter.ValidationRules
{
    public class ModelASubModelTypeValidation : TypeValidation
    {
        public ModelASubModelTypeValidation()
        {
            AddRule(new ValidationRule<ModelA>(Handler, "SubModel number", "Submodel ModelNumber must be the same as ModelNumber"));
        }


        public override IEnumerable<Type> TypeFor
        {
            get
            {
                return new[] { typeof(ModelA) };
            }
        }

        private static bool Handler(IRuleDescription rule, ModelA target)
        {
            if (target.SUbModel == null)
                return false;
            else if (target.SUbModel.ModelNumber != target.ModelNumber)
                return true;
            return false;
        }


    }
}

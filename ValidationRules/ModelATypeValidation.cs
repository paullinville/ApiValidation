using ApiTestValidationFilter.Models;
using FFP.Validations;
using System;
using System.Collections.Generic;
namespace ApiTestValidationFilter.ValidationRules
{
    public class ModelATypeValidation : TypeValidation
    {
        public ModelATypeValidation()
        {
            AddRule(new ModelAPocoRule()); //Add a custom rule class.
            AddRule(CommonPropRules.MaxStringLengthValidation("Description", 30));
            AddRule(new ValidationRule<ModelA>(ModelAHandler, "SubModelNull", "Submodel cannot be null"));
        }


        public override IEnumerable<Type> TypeFor
        {
            get
            {
                return new[] { typeof(ModelA) };
            }
        }

        private static bool ModelAHandler(IRuleDescription rule, ModelA target)
        {
            if (target.SUbModel == null)
                return true;
            return false;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validations;
using ApiTestValidationFilter.Models;

namespace ApiTestValidationFilter.ValidationRules
{
    public class ModelAPocoRule : TypedRuleBase<ModelA>
    {
        public ModelAPocoRule() : base("ModelNameRule", "ModelName cannot be null")
        {

        }
        public override bool IsBroken(ModelA itm)
        {
            return itm.ModelName == null;
        }
    }
}

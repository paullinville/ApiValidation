using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validations;

namespace ApiTestValidationFilter.ValidationRules
{
    public class ValidationPackage1 : BasicValidationPackage
    {

        protected override void AddValidationClasses()
        {
            base.AddValidationClasses();
        }
        public override string PackageName {
            get
            {
                return "ModelAPackage";
            }
        }

        protected override IEnumerable<Type> MakeTypes()
        {
            List<Type> types = new List<Type>();
            types.Add(typeof(ModelATypeValidation));
            types.Add(typeof(ModelASubModelTypeValidation));
            return types;
        }
    }
}

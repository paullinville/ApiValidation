using FFP.CoreUtilities;
using FFP.Validations;
using System;
using System.Collections.Generic;
namespace ApiTestValidationFilter.Models
{
    public class ModelA
    {
        public string ModelName { get; set; }
        public int ModelNumber { get; set; }
        public String Description { get; set; }
        public DateTime DateOf { get; set; }
        public ModelB SUbModel { get; set; }
    }


    public class ModelB
    {
        public string ModelBName { get; set; }
        public int ModelNumber { get; set; }
    }

    public class ValidatedModel : List<IRule>, IValidatedItem
    {
        public Guid BOID => throw new NotImplementedException();


        private List<IRule> InternalRules { get; set; } = new List<IRule>();
        public void AddRule(IRule Validation)
        {
            Add(Validation);
        }

        public string FriendlyName()
        {
            return "A Validated Model";
        }

        private BrokenValidationRules broke { get; set; }
        private BrokenValidationRules brokenRules(bool rechecking)
        {
            if (broke == null)
            {
                broke = new BrokenValidationRules();
            }
            else if (rechecking)
            {
                broke.Clear();
            }
            return broke;
        }

        public IEnumerable<IBrokenRule> InvalidRules(bool recheck = true)
        {
            brokenRules(recheck).AddRange(ValidationPackages.Validate(this));
            return broke;
        }

        public bool IsValid()
        {
            return InvalidRules(true).IsEmpty();
        }
    }
}

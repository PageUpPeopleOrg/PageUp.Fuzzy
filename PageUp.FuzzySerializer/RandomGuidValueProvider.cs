using System;
using Newtonsoft.Json.Serialization;

namespace PageUp.FuzzySerializer {
    public class RandomGuidValueProvider : IValueProvider
    {
        public void SetValue(object target, object value)
        {
            throw new NotImplementedException();
        }

        public object GetValue(object target)
        {
            return Guid.NewGuid();
        }
    }
}
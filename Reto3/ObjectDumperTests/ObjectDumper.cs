using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ObjectDumperTests {
    public class ObjectDumper<T> where T : class {
        private readonly Dictionary<string, Delegate> templates;

        public ObjectDumper() {
            templates = new Dictionary<string, Delegate>();
        }

        public IEnumerable<KeyValuePair<string, string>> Dump(T testClass) {
            var type = testClass.GetType();
                var properties = type.GetProperties().Where(property => property.CanRead).OrderBy(property => property.Name);
                foreach (var property in properties) {
                    var template = templates.ContainsKey(property.Name) ? templates[property.Name] : null;
                    var value = property.GetValue(testClass);
                    yield return
                        template != null
                            ? new KeyValuePair<string, string>(property.Name, template.DynamicInvoke(value) as string)
                            : new KeyValuePair<string, string>(property.Name, value != null ? value.ToString() : null);
                }
        }

        public void AddTemplateFor<TR>(Expression<Func<T, TR>> propExp, Func<TR, string> template) {
            var property = propExp.AsPropertyInfo();
            if (property == null) {
                return;
            }
            templates.Add(property.Name, template);
        }
    }
}
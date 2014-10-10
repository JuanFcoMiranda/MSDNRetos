using System;
using System.Linq.Expressions;
using System.Reflection;

namespace ObjectDumperTests {
    static class ExpressionExtensions {
        public static PropertyInfo AsPropertyInfo<T, TR>(this Expression<Func<T, TR>> expr) {
            var memberExp = expr.Body as MemberExpression;
            if (memberExp == null) {
                return null;
            }
            return memberExp.Member as PropertyInfo;
        }
    }
}
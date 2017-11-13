using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rzut.Core.i18n
{
    public static class Validation
    {
        public static bool ValidateRange<T1,T2>(T1 obj, Expression<Func<T1, T2>> expression, T2 min, T2 max, ICollection<string> errors, string typeSuffix = "") where T2: IComparable
        {
            var property = GetPropertyInfo(obj, expression);
            var val = (T2)property.GetValue(obj);
            var propname = property.Name;
            var objname = property.DeclaringType.Name;
            if(val.CompareTo(min) < 0 || val.CompareTo(max) > 0)
            {
                var msg = string.Format(i18n.Resources.Strings.ResourceManager.GetString($"Validation_Range_{typeSuffix}".TrimEnd('_')), Resources.Strings.ResourceManager.GetString($"{objname}_{propname}"), min, max);
                errors.Add(msg);
                return false;
            }
            return true;
        }
        public static PropertyInfo GetPropertyInfo<TSource, TProperty>(
    TSource source,
    Expression<Func<TSource, TProperty>> propertyLambda)
        {
            Type type = typeof(TSource);
            MemberExpression member;

            if (propertyLambda.Body is UnaryExpression ue)
            {
                member = ue.Operand as MemberExpression;
            }
            else
            {
                member = propertyLambda.Body as MemberExpression;
            }
            //MemberExpression member = (propertyLambda.Body as UnaryExpression).Operand as MemberExpression;
            if (member == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    propertyLambda.ToString()));

            PropertyInfo propInfo = member.Member as PropertyInfo;
            if (propInfo == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a field, not a property.",
                    propertyLambda.ToString()));
            /*
            if (type != propInfo.ReflectedType &&
                !type.IsSubclassOf(propInfo.ReflectedType))
                throw new ArgumentException(string.Format(
                    "Expresion '{0}' refers to a property that is not from type {1}.",
                    propertyLambda.ToString(),
                    type));*/

            return propInfo;
        }

        public static string GetLocalized(string property, string prefix)
        {
            return i18n.Resources.Strings.ResourceManager.GetString($"{prefix}_{property}");
        }
    }
}

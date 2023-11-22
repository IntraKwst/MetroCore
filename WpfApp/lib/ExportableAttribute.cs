using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WpfApp
{
    internal class ExportableAttribute : Attribute
    {
        public string Alias { get; set; }
        public static IEnumerable<PropertyInfo> GetProperties<T>() 
            => typeof(T).GetProperties().Where(x => IsDefined(x, typeof(ExportableAttribute)));

        public static IEnumerable<string> GetAliases<T>() 
            => GetProperties<T>().Select(x => x.GetCustomAttribute<ExportableAttribute>().Alias);
    }
}
using System.Collections.Generic;
using WpfApp;

internal static class ListWindowHelpers
{
    public static string CreateHtml<T>(IEnumerable<T> list)
    {
        var html = @"<table><tr>";
        foreach (var prop in ExportableAttribute.GetAliases<T>())
        {
            html += $"<th>{prop}</th>";
        }
        html += "</tr>";
        foreach (var item in list)
        {
            html += "<tr>";
            foreach (var prop in ExportableAttribute.GetProperties<T>())
            {
                html += $"<td>{prop.GetValue(item)}</td>";
            }
            html += "</tr>";
        }
        return html + "</table>";
    }


}
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace KRCO.CoreProject.Common.Functions
{
    public static class ServiceFunctions
    {
        public static string SerializeUrlPropertys(this object obj)
        {
            if (obj == null)
                return "";

            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return string.Concat("?", string.Join("&", properties.ToArray()));
        }

        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var xmlserializer = new XmlSerializer(typeof(T));
            using (var stringWriter = new StringWriter())
            {
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value);
                    return stringWriter.ToString();
                }
            }
        }
    }
}

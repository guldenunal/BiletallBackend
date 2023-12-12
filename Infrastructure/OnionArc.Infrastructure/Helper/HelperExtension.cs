using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biletall.Infrastructure.Helper
{
   public static class HelperExtension
    {
        public static string NullOrValue(this XElement element, string elementName)

        {

            if (element?.Element(elementName) == null)

                return null;

            else

                return element.Element(elementName).Value;

        }
    }
}

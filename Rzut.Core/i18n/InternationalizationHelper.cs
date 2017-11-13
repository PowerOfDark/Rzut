using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Rzut.Core.i18n
{
    public static class InternationalizationHelper
    {
        public static readonly string[] SupportedLanguages = {"pl", "en", "de"};
        public static ResourceManager ResourceManager => new ResourceManager(typeof(Rzut.Core.i18n.Resources.Strings));

        public static void Set(string locale)
        {
            i18n.Resources.Strings.Culture = new CultureInfo(locale);
        }

        public static CultureInfo Get() => i18n.Resources.Strings.Culture;
    }
}

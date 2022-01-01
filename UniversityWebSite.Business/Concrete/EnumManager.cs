using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.Business.Concrete
{
    public static class EnumManager
    {
        public static Enum EnumParser(string expression)
        {
            expression = expression.ToLower();
            switch (expression)
            {
                case "university":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.University;
                case "academic":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.Academic;
                case "research":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.Research;
                case "specialization":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.Specialization;
                case "fastaccess":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.FastAccess;
                default:
                    throw new Exception("Something went wrong");
            }
        }
    }
}

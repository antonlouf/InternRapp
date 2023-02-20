using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.ValidationFunctions;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Commands.UpdateInternShip;

namespace backend.Application.InternShips.Common;
public class ValidationFunction
{
    public static bool IsVersionValid(IList<LanguageSpecificUpdateInternShipDto> arg)
    {
        foreach (var version in arg)
        {
            if (!version.NeededKnowledge.IsStringWithoutSpecialChars()) return false;
            if (version.NeededKnowledge == null || version.NeededKnowledge == "") return false;

            if (!version.TitleContent.IsStringWithoutSpecialChars()) return false;
            if (version.TitleContent == null || version.TitleContent == "") return false;

            if (!version.Comment.IsStringWithoutSpecialChars()) return false;
            if (version.Comment == null || version.Comment == "") return false;

            if (!version.Content.IsStringWithoutSpecialChars()) return false;
            if (version.Content == null || version.Content == "") return false;

            if (!version.Description.IsStringWithoutSpecialChars()) return false;
            if (version.Description == null || version.Description == "") return false;

            if (!version.Location.IsStringWithoutSpecialChars()) return false;
            if (version.Location == null || version.Location == "") return false;

            if (!version.KnowledgeToDevelop.IsStringWithoutSpecialChars()) return false;
            if (version.KnowledgeToDevelop == null || version.KnowledgeToDevelop == "") return false;





        }
        return true;
    }
    public static bool IsVersionValid(IList<LanguageSpecificInternShipDto> arg)
    {
        foreach (var version in arg)
        {
            if (!version.NeededKnowledge.IsStringWithoutSpecialChars()) return false;
            if (version.NeededKnowledge == null || version.NeededKnowledge == "") return false;

            if (!version.TitleContent.IsStringWithoutSpecialChars()) return false;
            if (version.TitleContent == null || version.TitleContent == "") return false;

            if (!version.Comment.IsStringWithoutSpecialChars()) return false;
            if (version.Comment == null || version.Comment == "") return false;

            if (!version.Content.IsStringWithoutSpecialChars()) return false;
            if (version.Content == null || version.Content == "") return false;

            if (!version.Description.IsStringWithoutSpecialChars()) return false;
            if (version.Description == null || version.Description == "") return false;

            if (!version.Location.IsStringWithoutSpecialChars()) return false;
            if (version.Location == null || version.Location == "") return false;

            if (!version.KnowledgeToDevelop.IsStringWithoutSpecialChars()) return false;
            if (version.KnowledgeToDevelop == null || version.KnowledgeToDevelop == "") return false;





        }
        return true;
    }
}

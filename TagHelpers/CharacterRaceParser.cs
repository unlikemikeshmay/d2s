using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace bulkybook.TagHelpers
{
    [HtmlTargetElement("raceParser")]
    public class CharacterRaceParser : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var childContent =  output.GetChildContentAsync().Result;
            var content = childContent.GetContent();
            switch (Convert.ToInt32(content))
            {
                case 0:
                output.Content.SetContent("Human");
                break;
                case 1:
                output.Content.SetContent("Awoken");
                break;
                case 2:
                output.Content.SetContent("Exo");
                break;
                default:
                output.Content.SetContent("Unknown");
                break;
            }
        }
    }
}
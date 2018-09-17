using DO_Login.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DO_Login.Services
{
    public class HtmlElementService
    {
        public static List<OfferModel> GetOffers(String htmlContent)
        {
            List<HtmlNode> offersElements = new List<HtmlNode>();

            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);

            HtmlNodeCollection elementsCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='auctionList auction_list_current']//tr[@class]");

            List<OfferModel> offers = new List<OfferModel>();

            foreach (HtmlNode element in elementsCollection)
            {
                offers.Add(new OfferModel()
                {
                    img = element.SelectSingleNode(".//td[@class='firstColumn']//img").Attributes["src"].Value,
                    itemKey = element.Attributes["itemkey"].Value,
                    name = element.SelectSingleNode(".//td[@class='auction_item_name_col']").InnerText.Trim(),
                    highest = element.SelectSingleNode(".//td[@class='auction_item_highest']").InnerText.Trim(),
                    currentBid = Convert.ToInt64(Convert.ToDecimal(element.SelectSingleNode(".//td[@class='auction_item_current']").InnerText.Trim().Replace(".", string.Empty))),
                    youBid = Convert.ToInt64(Convert.ToDecimal(element.SelectSingleNode(".//td[@class='auction_item_you']").InnerText.Trim().Replace(".", string.Empty))),
                    lootId = element.SelectSingleNode(".//td[@class='auction_item_instant']//input[@id='" + element.Attributes["itemkey"].Value + "_lootId']").Attributes["value"].Value
                });
            }

            return offers;
        }

        public static UserModel GetUser(String htmlContent)
        {
            List<HtmlNode> offersElements = new List<HtmlNode>();

            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);

            UserModel user = new UserModel();

            var a = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='header_money']").InnerText.Trim();

            user.credits = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='header_money']").InnerText.Trim();
            user.name = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='ppLeftTopName profilePageFont']").InnerText.Trim();
            return user;
        }
    }
}

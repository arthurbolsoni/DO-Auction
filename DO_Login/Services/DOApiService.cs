using DO_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DO_Login.Services
{
    public class DOApiService
    {
        public UserModel user { get; set; }
        public List<OfferModel> offers { get; set; }

        public DOApiService(String SID, String server)
        {
            String htmlContent = GetAuctionBySID(SID, server);
            if (htmlContent == null) new Exception();

            offers = HtmlElementService.GetOffers(htmlContent);
            user = HtmlElementService.GetUser(GetPilotSheetBySID(SID,server));
            user.SID = SID;
            user.server = server;
        }

        public void setBid(List<BidModel> bids)
        {
            string number = "";

            bids.FindAll(bid => bid.isRunning == false).ForEach(bid =>
            {
                String post = "reloadToken=" + Helpers.TokenGenerator.Generate(32) +
                    "&auctionType=hour" +
                    "&subAction=bid" +
                    "&lootId=" + bid.Offer.lootId +
                    "&itemId=" + bid.Offer.itemKey +
                    "&credits=" + bid.YouNewBid +
                    "&auction_buy_button=LICITAR";
                WebRequestService.PostRequest("https://" + user.server + "/indexInternal.es?action=internalAuction", post);
                bid.isRunning = true;
            });
        }

        public String GetAuctionBySID(String SID = null, String server = null)
        {
            if (server == null) server = user.server;

            if (SID != null)
            {
                WebRequestService.Cookies = new CookieCollection() { new Cookie("dosid", SID, "/", "darkorbit.com") };
            }

            try
            {
                String htmlContent = WebRequestService.GetRequest("https://" + server + "/indexInternal.es?action=internalAuction");
                if (getSIDByHtml(htmlContent) == null)
                {
                    new Exception();
                }
                return htmlContent;

            }
            catch
            {
                new Exception();
                return null;
            }
        }

        public String GetPilotSheetBySID(String SID = null, String server = null)
        {
            if (server == null) server = user.server;

            if (SID != null)
            {
                WebRequestService.Cookies = new CookieCollection() { new Cookie("dosid", SID, "/", "darkorbit.com") };
            }

            try
            {
                String htmlContent = WebRequestService.GetRequest("https://" + server + "/indexInternal.es?action=internalPilotSheet");
                if (getSIDByHtml(htmlContent) == null)
                {
                    new Exception();
                }
                return htmlContent;

            }
            catch
            {
                new Exception();
                return null;
            }
        }


        public static void newLoginWebBrowser(String user, String password)
        {

        }

        public static String getSIDByHtml(String htmlContent)
        {
            String SID = null;

            String regex = @"(?:dosid=)(\w*)";

            RegexOptions options = RegexOptions.Multiline;
            foreach (Match m in Regex.Matches(htmlContent, regex, options))
            {
                SID = m.Groups[1].ToString();
            }

            return SID;
        }

        public static TimeSpan GetTime(String htmlContent)
        {
            DateTime time = new DateTime();

            String regex = @"(counterHour )( = ){((.|\n)*?)}";
            String regex2 = @":*\d+";

            RegexOptions options = RegexOptions.Multiline;
            foreach (Match m in Regex.Matches(htmlContent, regex, options))
            {

                var a = Regex.Matches(m.Groups[3].ToString(), regex2, options);

                String segund = a[0].ToString().Count() == 1 ? "0" + a[0].ToString() : a[0].ToString();
                String minut = a[1].ToString().Count() == 1 ? "0" + a[1].ToString() : a[1].ToString();
                String hour = a[2].ToString().Count() == 1 ? "0" + a[2].ToString() : a[2].ToString();

                String t = hour + ":" + minut + ":" + segund;

                TimeSpan tm;

                TimeSpan.TryParse(t, out tm);

                return tm;
            }

            return new TimeSpan();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace ParseXML
{

    public partial class main : System.Web.UI.Page
    {
        protected string myVar = "hello from the server!";
        protected string t;

        protected void Page_Load(object sender, EventArgs e)
        {
            t = getNodes("0887307280");
        }

        protected string getNodes(string isbn)
        {
            string titles = "";
            string url = "http://www.worldcat.org/webservices/catalog/search/opensearch?q="+isbn+"&wskey=fRDCboLGRMyPgWPEXNT6ybLDe9ZySdp1VH9SxWDMxiyjFRTHc2ATZVTYbrGgXwXEsM4hQozz3lPapR3R";
            //string url1 = "file:///C:/Users/Administrator/Desktop/prog/xml/worldCat.xml";

            XmlDocument d = new XmlDocument();
            d.Load(url);
            XmlNodeList n = d.GetElementsByTagName("title");

            for (int i = 0; i < n.Count; i++ )
            {
                titles += n[i].InnerText + "<br />";
            }

            return titles;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
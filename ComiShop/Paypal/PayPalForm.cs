using ComiShop.Helpers;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace ComiShop.Paypal
{
    public class PayPalForm
    {
        public String PreparePOSTForm(string url, NameValueCollection data)
        {
            string formID = "PostForm";
            StringBuilder strForm = new StringBuilder();
            strForm.Append("<form id=\"" + formID + "\" name=\"" +
                            formID + "\" action=\"" + url +
                            "\" method=\"POST\">");

            foreach (string key in data)
            {
                strForm.Append("<input type=\"hidden\" name=\"" + key +
                                "\" value=\"" + data[key] + "\">");
            }

            strForm.Append("</form>");
            StringBuilder strScript = new StringBuilder();
            strScript.Append("<script language=\"javascript\">");
            strScript.Append("var v" + formID + " = document." +
                                formID + ";");
            strScript.Append("v" + formID + ".submit();");
            strScript.Append("</script>");
            return strForm.ToString() + strScript.ToString();
        }
    }
}

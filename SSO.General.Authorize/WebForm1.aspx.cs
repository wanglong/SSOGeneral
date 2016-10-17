﻿using SSO.General.Helper;
using System;

namespace SSO.General.Authorize
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    string result = SSOGeneralSameDomain.GetCookieValue("CookiesTest", this);
                    txtUserData.Text = result;
                }
            }
        }

        protected void SignOut_Click(object sender, EventArgs e)
        {
            SSOGeneralSameDomain.LogUp();
        }
    }
}
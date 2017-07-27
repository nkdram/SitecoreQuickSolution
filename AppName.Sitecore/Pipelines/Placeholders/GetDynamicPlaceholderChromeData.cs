﻿using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Pipelines.GetChromeData;
using Sitecore.Web.UI.PageModes;
using System;
using System.Text.RegularExpressions;

namespace AppName.SCCMS.Pipelines.Placeholders
{
    /// <summary>
    /// Replaces the Displayname of the Placeholder rendering with the dynamic "parent"
    /// </summary>
    public class GetDynamicPlaceholderChromeData : GetChromeDataProcessor
    {
        //text that ends in a GUID
        private const string DYNAMIC_KEY_REGEX = @"(.+)_[\d\w]{8}\-([\d\w]{4}\-){3}[\d\w]{12}";

        public override void Process(GetChromeDataArgs args)
        {
            Assert.ArgumentNotNull(args, "args");
            Assert.IsNotNull(args.ChromeData, "Chrome Data");
            if ("placeholder".Equals(args.ChromeType, StringComparison.OrdinalIgnoreCase))
            {
                string argument = args.CustomData["placeHolderKey"] as string;

                string placeholderKey = argument;
                Regex regex = new Regex(DYNAMIC_KEY_REGEX);
                Match match = regex.Match(placeholderKey);
                if (match.Success && match.Groups.Count > 0)
                {
                    // Is a Dynamic Placeholder
                    placeholderKey = placeholderKey.Contains("/") ? placeholderKey.Split('/')[1] : match.Groups[1].Value;
                }
                else
                {
                    return;
                }

                // Handles replacing the displayname of the placeholder area to the master reference
                Item item = null;
                if (args.Item != null)
                {
                    string layout = ChromeContext.GetLayout(args.Item);
                    item = Client.Page.GetPlaceholderItem(placeholderKey, args.Item.Database, layout);
                    if (item != null)
                    {
                        args.ChromeData.DisplayName = item.DisplayName;
                    }
                    if ((item != null) && !string.IsNullOrEmpty(item.Appearance.ShortDescription))
                    {
                        args.ChromeData.ExpandedDisplayName = item.Appearance.ShortDescription;
                    }
                }
            }
        }
    }
}

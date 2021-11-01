using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;

namespace CNBlogsSpliter
{
    public static class CBridge
    {
       public struct InfoPak
        {
            public bool IsMarkDown;
            public bool IsSavePic;
            public string OutputDir;
            public SyndicationItem[] Items;
        }
    }
}

using System.Diagnostics.CodeAnalysis;
using Jackett.Common.Indexers.Abstract;
using Jackett.Common.Models;
using Jackett.Common.Services.Interfaces;
using Jackett.Common.Utils.Clients;
using NLog;

namespace Jackett.Common.Indexers
{
    [ExcludeFromCodeCoverage]
    public class CinemaZ : AvistazTracker
    {
        public CinemaZ(IIndexerConfigurationService configService, WebClient wc, Logger l, IProtectionService ps)
            : base(id: "cinemaz",
                   name: "CinemaZ",
                   description: "Part of the Avistaz network.",
                   link: "https://cinemaz.to/",
                   caps: new TorznabCapabilities
                   {
                       SupportsImdbMovieSearch = true
                       // SupportsImdbTVSearch = true (supported by the site but disabled due to #8107)
                   },
                   configService: configService,
                   client: wc,
                   logger: l,
                   p: ps)
        {
            AddCategoryMapping(1, TorznabCatType.Movies);
            AddCategoryMapping(1, TorznabCatType.MoviesUHD);
            AddCategoryMapping(1, TorznabCatType.MoviesHD);
            AddCategoryMapping(1, TorznabCatType.MoviesSD);
            AddCategoryMapping(2, TorznabCatType.TV);
            AddCategoryMapping(2, TorznabCatType.TVUHD);
            AddCategoryMapping(2, TorznabCatType.TVHD);
            AddCategoryMapping(2, TorznabCatType.TVSD);
            AddCategoryMapping(3, TorznabCatType.Audio);
        }
    }
}

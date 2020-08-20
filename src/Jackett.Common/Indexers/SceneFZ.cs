using System.Diagnostics.CodeAnalysis;
using Jackett.Common.Indexers.Abstract;
using Jackett.Common.Models;
using Jackett.Common.Services.Interfaces;
using Jackett.Common.Utils.Clients;
using NLog;

namespace Jackett.Common.Indexers
{
    [ExcludeFromCodeCoverage]
    public class SceneFZ : XtremeZoneTracker
    {
        public override string[] LegacySiteLinks { get; protected set; } = {
            "https://www.scenefz.me/",
            "https://www.u-torrents.ro/"
        };

        public SceneFZ(IIndexerConfigurationService configService, WebClient wc, Logger l, IProtectionService ps)
            : base(
                id: "scenefz",
                name: "SceneFZ",
                description: "SceneFZ is a ratioless ROMANIAN Private Torrent Tracker for MOVIES / TV / GENERAL",
                link: "https://scenefz.me/",
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
            AddCategoryMapping(38, TorznabCatType.Movies, "Movies-Packs");
            AddCategoryMapping(10, TorznabCatType.MoviesSD, "Movies-SD");
            AddCategoryMapping(35, TorznabCatType.MoviesSD, "Movies-SD-RO");
            AddCategoryMapping(8, TorznabCatType.MoviesHD, "Movies-HD");
            AddCategoryMapping(29, TorznabCatType.MoviesHD, "Movies-HD-RO");
            AddCategoryMapping(7, TorznabCatType.MoviesDVD, "Movies-DVD");
            AddCategoryMapping(2, TorznabCatType.MoviesDVD, "Movies-DVD-RO");
            AddCategoryMapping(17, TorznabCatType.MoviesBluRay, "Movies-BluRay");
            AddCategoryMapping(24, TorznabCatType.MoviesBluRay, "Movies-BluRayRO");
            AddCategoryMapping(59, TorznabCatType.MoviesForeign, "Movies-RO");
            AddCategoryMapping(57, TorznabCatType.MoviesUHD, "Movies-UHD-RO");
            AddCategoryMapping(61, TorznabCatType.MoviesUHD, "Movies-UHD");

            AddCategoryMapping(41, TorznabCatType.TV, "TV-Packs");
            AddCategoryMapping(66, TorznabCatType.TVFOREIGN, "TV-Packs-RO");
            AddCategoryMapping(45, TorznabCatType.TVSD, "TV-SD");
            AddCategoryMapping(46, TorznabCatType.TVSD, "TV-SD-RO");
            AddCategoryMapping(43, TorznabCatType.TVHD, "TV-HD");
            AddCategoryMapping(44, TorznabCatType.TVHD, "TV-HD-RO");
            AddCategoryMapping(60, TorznabCatType.TVFOREIGN, "TV-RO");

            AddCategoryMapping(11, TorznabCatType.PCGames, "Games-PC");
            AddCategoryMapping(52, TorznabCatType.Console, "Games-Console");
            AddCategoryMapping(1, TorznabCatType.PC0day, "Appz");
            AddCategoryMapping(14, TorznabCatType.PC, "Linux");
            AddCategoryMapping(37, TorznabCatType.PCMac, "Mac");
            AddCategoryMapping(19, TorznabCatType.PCPhoneOther, "Mobile");

            AddCategoryMapping(62, TorznabCatType.TV, "Cartoons");
            AddCategoryMapping(3, TorznabCatType.TVAnime, "Anime/Hentai");
            AddCategoryMapping(6, TorznabCatType.Books, "eBooks");
            AddCategoryMapping(5, TorznabCatType.Audio, "Music");
            AddCategoryMapping(64, TorznabCatType.AudioVideo, "Music Videos");
            AddCategoryMapping(18, TorznabCatType.Other, "Images");
            AddCategoryMapping(22, TorznabCatType.TVSport, "Sport");
            AddCategoryMapping(58, TorznabCatType.TVSport, "Sports-RO");
            AddCategoryMapping(9, TorznabCatType.TVDocumentary, "Documentary");
            AddCategoryMapping(63, TorznabCatType.TVDocumentary, "Documentary-RO");
            AddCategoryMapping(65, TorznabCatType.Other, "Tutorial");
            AddCategoryMapping(67, TorznabCatType.OtherMisc, "Miscellaneous");

            AddCategoryMapping(15, TorznabCatType.XXX, "XXX");
            AddCategoryMapping(47, TorznabCatType.XXX, "XXX-DVD");
            AddCategoryMapping(48, TorznabCatType.XXX, "XXX-HD");
            AddCategoryMapping(49, TorznabCatType.XXXImageset, "XXX-IMGSet");
            AddCategoryMapping(50, TorznabCatType.XXX, "XXX-Packs");
            AddCategoryMapping(51, TorznabCatType.XXX, "XXX-SD");
        }
    }
}

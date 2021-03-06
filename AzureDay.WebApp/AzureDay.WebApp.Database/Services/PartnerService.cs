﻿using System;
using System.Linq;
using System.Collections.Generic;
using AzureDay.WebApp.Database.Entities;
using AzureDay.WebApp.Database.Enums;

namespace AzureDay.WebApp.Database.Services
{
    public sealed class PartnerService : BaseService<PartnerEntity, string>
    {
        protected override List<PartnerEntity> PopulateStorage()
        {
            return new List<PartnerEntity>
            {
                new PartnerEntity
                {
                    Id = "Microsoft",
                    Title = Localization.App.Service.Partners.Microsoft.Title,
                    Description = Localization.App.Service.Partners.Microsoft.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/microsoft.jpg",
                    WebUrl = "https://www.microsoft.com/uk-ua/",
                    PartnerType = PartnerType.Info | PartnerType.Gold | PartnerType.Workshop
                },
                new PartnerEntity
                {
                    Id = "LuxoftUkraine",
                    Title = Localization.App.Service.Partners.Luxoft.Title,
                    Description = Localization.App.Service.Partners.Luxoft.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/Luxoft_v1.jpg",
                    WebUrl = "https://www.luxoft.com/",
                    PartnerType = PartnerType.Gold
                },
                new PartnerEntity
                {
                    Id = "Beetroot",
                    Title = Localization.App.Service.Partners.Beetroot.Title,
                    Description = Localization.App.Service.Partners.Beetroot.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/Beetroot_v1.png",
                    WebUrl = "https://beetroot.se/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "Bodo",
                    Title = Localization.App.Service.Partners.Bodo.Title,
                    Description = Localization.App.Service.Partners.Bodo.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/bodo.png",
                    WebUrl = "https://www.bodo.ua/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "BrainBasketFoundation",
                    Title = Localization.App.Service.Partners.BrainBasket.Title,
                    Description = Localization.App.Service.Partners.BrainBasket.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/BrainBasketFoundation_v1.png",
                    WebUrl = "https://brainbasket.org/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "BrainTV",
                    Title = Localization.App.Service.Partners.BrainTV.Title,
                    Description = Localization.App.Service.Partners.BrainTV.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/brain_tv.jpg",
                    WebUrl = "https://braintv.net/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "Devart",
                    Title = Localization.App.Service.Partners.DevArt.Title,
                    Description = Localization.App.Service.Partners.DevArt.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/devart_v1.png",
                    WebUrl = "https://www.devart.com/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "DOU",
                    Title = Localization.App.Service.Partners.Dou.Title,
                    Description = Localization.App.Service.Partners.Dou.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/dou.png",
                    WebUrl = "https://dou.ua/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "ITClusterKonotop",
                    Title = Localization.App.Service.Partners.ITClusterKonotop.Title,
                    Description = Localization.App.Service.Partners.ITClusterKonotop.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/itclusterkonotop_v1.png",
                    WebUrl = "http://itcluster.konotop.info/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "ITRatingUkraine",
                    Title = Localization.App.Service.Partners.ITRatingUkraine.Title,
                    Description = Localization.App.Service.Partners.ITRatingUkraine.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/itratingsukraine_v1.png",
                    WebUrl = "https://it-rating.in.ua/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "KyivITCluster",
                    Title = Localization.App.Service.Partners.KyivITCluster.Title,
                    Description = Localization.App.Service.Partners.KyivITCluster.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/KyivITCluster.png",
                    WebUrl = "https://itcluster.kiev.ua/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "ScrumUkraine",
                    Title = Localization.App.Service.Partners.ScrumUkraine.Title,
                    Description = Localization.App.Service.Partners.ScrumUkraine.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/scrum_ua.png",
                    WebUrl = "http://www.scrum.ua/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "WeeklyIT",
                    Title = Localization.App.Service.Partners.WeeklyIT.Title,
                    Description = Localization.App.Service.Partners.WeeklyIT.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/weeklyit.png",
                    WebUrl = "http://weekly-it.com/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "DataScienceUA",
                    Title = Localization.App.Service.Partners.DataScienceUA.Title,
                    Description = Localization.App.Service.Partners.DataScienceUA.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/DataScienceUA.png",
                    WebUrl = "https://data-science.com.ua/ua/conferences/data-science-ua-conference-5th/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "DevDigest",
                    Title = Localization.App.Service.Partners.DevDigest.Title,
                    Description = Localization.App.Service.Partners.DevDigest.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/devdigest.png",
                    WebUrl = "https://devdigest.today/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "ITClusterVinnytsia",
                    Title = Localization.App.Service.Partners.ITClusterVinnytsia.Title,
                    Description = Localization.App.Service.Partners.ITClusterVinnytsia.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/ITClusterVinnytsia.jpg",
                    WebUrl = "https://www.it-association.vn.ua/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "Skyworker",
                    Title = Localization.App.Service.Partners.Skyworker.Title,
                    Description = Localization.App.Service.Partners.Skyworker.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/Skyworker.jpg",
                    WebUrl = "https://skyworker.com.ua/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "Ciklum",
                    Title = Localization.App.Service.Partners.Ciklum.Title,
                    Description = Localization.App.Service.Partners.Ciklum.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/ciklum_v3.png",
                    WebUrl = "https://www.ciklum.com/",
                    PartnerType = PartnerType.Silver
                },
                new PartnerEntity
                {
                    Id = "Dev-Pro",
                    Title = Localization.App.Service.Partners.DevPro.Title,
                    Description = Localization.App.Service.Partners.DevPro.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/DevPro.png",
                    WebUrl = "https://www.dev-pro.net/",
                    PartnerType = PartnerType.Silver
                },
                new PartnerEntity
                {
                    Id = "Wirex",
                    Title = Localization.App.Service.Partners.Wirex.Title,
                    Description = Localization.App.Service.Partners.Wirex.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/Wirex.png",
                    WebUrl = "https://wirexapp.com/",
                    PartnerType = PartnerType.Bronze
                },
                new PartnerEntity
                {
                    Id = "Salateira",
                    Title = Localization.App.Service.Partners.Salateira.Title,
                    Description = Localization.App.Service.Partners.Salateira.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/salateira_v1.jpg",
                    WebUrl = "https://salateira.ua/",
                    PartnerType = PartnerType.Info | PartnerType.Raffle
                },
                new PartnerEntity
                {
                    Id = "Eleks",
                    Title = Localization.App.Service.Partners.Eleks.Title,
                    Description = Localization.App.Service.Partners.Eleks.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/ELEKS.png",
                    WebUrl = "https://eleks.com/",
                    PartnerType = PartnerType.Silver
                },
                new PartnerEntity
                {
                    Id = "SmartIT",
                    Title = Localization.App.Service.Partners.SmartIT.Title,
                    Description = Localization.App.Service.Partners.SmartIT.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/smart_it.jpg",
                    WebUrl = "http://www.smart-it.com/",
                    PartnerType = PartnerType.Info
                },
                new PartnerEntity
                {
                    Id = "ITKPI",
                    Title = Localization.App.Service.Partners.ITKPI.Title,
                    Description = Localization.App.Service.Partners.ITKPI.Description.Replace(Environment.NewLine, "<br/>"),
                    LogoUrl = "/images/logos/ITKPI.png",
                    WebUrl = "https://t.me/itkpi",
                    PartnerType = PartnerType.Info
                },
            };
        }

        public IEnumerable<PartnerEntity> GetPartnersByType(PartnerType partnerType)
        {
            return Storage
                .Where(x => x.PartnerType.HasFlag(partnerType))
                .OrderBy(x => x.Id);
        }
    }
}
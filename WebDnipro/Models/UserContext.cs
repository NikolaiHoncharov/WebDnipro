using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebDnipro.Models
{
    public class UserContext: DbContext 
    {
        public UserContext() :
            base("UserConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<OtherServices> OtherServices { get; set; }
        public DbSet<MessageFrmUser> MessageFrmUsers { get; set; }
    }

    //public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    //{
    //    protected override void Seed(UserContext db)
    //    {
    //        db.Roles.Add(new Role { Id = 1, Name = "admin" });
    //        db.Roles.Add(new Role { Id = 2, Name = "user" });
    //        db.Users.Add(new User
    //        {
    //            Name = "НиколайВикторович",
    //            Email = "Goncharovnik@ukr.net",
    //            Password = "123456",
    //            RoleId = 1
    //        });

    //        db.Services.AddRange( new Services[] { new Services{  ServicesId = 1, Title= "МАГАЗИН", Description = "Интернет-магазин — сайт с каталогом продукции, с помощью которого клиент может заказать нужные ему товары. Используются различные системы расчётов: от пересылки товаров наложенным платежом или автоматической пересылки счета по факсу до расчётов с помощью пластиковых карт.",
    //            linkImg = "/Content/image/index/Shop.jpg"},
    //            new Services{  ServicesId = 2, Title= "ВИЗИТКА", Description = "Сайт-визитка - небольшой сайт, состоящий из нескольких веб-страницы (3-7 стр), содержащий основную информацию об организации, частном лице, компании, товарах или услугах, контактные данные. Сайт-визитка может быть как статическим (все данные, изображения, контакты загружаются при создании сайта), так и динамическим сайтом (включает себя авторизацию администраторов и модераторов для управления и изменения данных сайта). Сайт-портфолио разновидность динамического сайта-визитки, включает себя раздел для загрузки изображений (фотографий, видов работ и т.д.)",
    //            linkImg = "/Content/image/index/vizitka.jpg"},
    //            new Services{  ServicesId = 3, Title= "КАТАЛОГ", Description = "В каталоге присутствует подробное описание товаров, технические и потребительские данные, отзывы экспертов и т.д. На таких сайтах размещается информация о товарах, которую невозможно поместить в прайс-лист. Возможность добавлять и удалять товары, объявлять акции, привязывать текущие цены к котировкам валют...",
    //            linkImg = "/Content/image/index/Catalog.jpg"}
    //        });

    //        db.OtherServices.AddRange(new OtherServices[] { new OtherServices{ OtherServicesId = 1, Title= "ХОСТИНГ", Description = "Хостинг - предоставление ресурсов для размещения web-сайтов на сервере, постоянно находящемся в сети Интернет. Одной из наших дополнительных услуг является хостинг, тем самым мы избавляем Вас от необходимости самостоятельного поиска хостера и знакомства со всеми техническими деталями работы на хостинге лично.",
    //            LinkImg = "/Content/image/index/hosting.jpg"},
    //            new OtherServices{  OtherServicesId = 2, Title= "ПРИОБРЕТЕНИЕ ДОМЕННОГО ИМЕНИ", Description = "Доменное имя - это имя вашего сайта в сети Интернет. Доменное имя, в отличие от человеческих имен, уникально, т.е. двух одинаковых быть не может. Поэтому, если Вы делаете серьезный сайт, то нужно уделить должное внимание подбору этого имени. Мы поможем Вам подобрать уникальное имя для сайта в любой зоне, такой как .ru, .com, .net и т.д.",
    //            LinkImg = "/Content/image/index/DomainName.jpg"},
    //            new OtherServices{  OtherServicesId = 3, Title= "ПРОДВИЖЕНИЕ САЙТОВ", Description = "Продвижение сайтов или поисковая оптимизация (SEO) - комплекс мер по внутренней и внешней оптимизации, для поднятия позиций сайта в результатах выдачи поисковых систем по определенным запросам пользователей, с целью увеличения трафика (для инфоресурсов) и потенциальных клиентов (для коммерческих ресурсов) и последующей монетизации этого трафика.",
    //            LinkImg = "/Content/image/index/seo.jpg"}
    //        });
    //        base.Seed(db);
    //    }
    //}


}
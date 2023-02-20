using Microsoft.EntityFrameworkCore;

namespace MusicStore.Web.Models;

public static class SeedData
{
    public static void EnsurePopulated(IApplicationBuilder app)
    {
        StoreDbContext context = app.ApplicationServices.CreateScope()
            .ServiceProvider.GetRequiredService<StoreDbContext>();
        if(context.Database.GetPendingMigrations().Any()) { context.Database.Migrate(); }

        if (context.Products.Count() == 0)
        {
            context.Products.AddRange(
                new Product { 
                    ProductName = "Акусти́ческая гита́ра", 
                    ProductDescription = "струнный щипковый музыкальный инструмент (в большинстве разновидностей с шестью струнами) из семейства гитар, звучание которого осуществляется благодаря колебанию струн, усиливаемому за счёт резонирования полого корпуса.", 
                    ProductCategory = "Instruments", 
                    Price = 5.0M },
                new Product { 
                    ProductName = "Цифровые пианино", 
                    ProductDescription = "электронный музыкальный инструмент, имеющий клавиатуру фортепиано и воспроизводящий звучание акустических фортепиано. Может также сочетать в себе возможности синтезатора и MIDI-контроллера. Может иметь корпус, напоминающий пианино, электрическое пианино или небольшой рояль. ", 
                    ProductCategory = "Instruments", 
                    Price = 117000.0M },
                new Product { 
                    ProductName = "Рекордер", 
                    ProductDescription = "Профессиональное устройство, предназначенное для качественной внестудийной записи звука при кинопроизводстве и телерадиовещании. Как правило, может работать автономно от аккумуляторов и оснащено симметричным входом для подключения внешнего микрофона. Основное применение в кинопроизводстве — для записи синхронной фонограммы во время съёмки фильма, ролика или сериала.", 
                    ProductCategory = "Devices", 
                    Price = 56910.0M },
                new Product { 
                    ProductName = "Микрофон", 
                    ProductDescription = "Студийный конденсаторный микрофон (направленность - кардиоида) в комплекте с держателем и транспортным кейсом ", 
                    ProductCategory = "Devices", 
                    Price = 3590.0M },
                new Product { 
                    ProductName = "Акустические ударные", 
                    ProductDescription = "Ударная установка из 5-ти барабанов (цвет - BLACK) со стойками (бочка 16х22, томы 7x10, 8х12 напольный 15х16, малый 5,5х14) со стойкой для малого барабана, стойкой для хай-хэта, стойкой под тарелку, педалью для бас-бочки ", 
                    ProductCategory = "Instruments", 
                    Price = 49500.0M },
                new Product { 
                    ProductName = "Бас-гитара. Основы", 
                    ProductDescription = "За 1,5 месяца вы научитесь играть бас-партии на примере популярных песен, создавать собственные партии на аккордах и интервалах. Все это — под руководством опытного преподавателя.", 
                    ProductCategory = "Courses", 
                    Price = 3990.0M },
                new Product { 
                    ProductName = "Тремоло губные гармошки",
                    ProductDescription = "Губная гармошка тремоло", 
                    ProductCategory = "Instruments", 
                    Price = 1320.0M },
                new Product { 
                    ProductName = "Вокал. Основы", 
                    ProductDescription = "За 1,5 месяца вы научитесь попадать в ноты, контролировать дыхание и работу голосовых связок. А также разовьете дикцию, артикуляцию и красиво споете несколько песен. Все это — под руководством опытного преподавателя.", 
                    ProductCategory = "Courses", 
                    Price = 3990.0M },
                new Product { 
                    ProductName = "Сабвуфер", 
                    ProductDescription = "Напольный активный сабвуфер оснащен большим НЧ-драйвером, диаметром 15\". Максимальная мощность акустики составляет 3000 Вт.", 
                    ProductCategory = "Devices", 
                    Price = 55990.0M },
                new Product { 
                    ProductName = "Гармонь", 
                    ProductDescription = "Одноголосая гармонь без регистра, звукоряд основан на неполной хроматической гамме.", 
                    ProductCategory = "Instruments", 
                    Price = 18520.0M },
                new Product { 
                    ProductName = "Контрабас", 
                    ProductDescription = "надежный полноразмерный контрабас, который является идеальным выбором для начинающих и учащихся, поскольку он прочен, хорошо звучит и стоит весьма скромно.", 
                    ProductCategory = "Instruments", 
                    Price = 40830.0M }
                );
            context.SaveChanges();
        }
    }
}

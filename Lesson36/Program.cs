using System;
using System.Globalization;

DateTime dateTime = new DateTime();
Console.WriteLine(dateTime);
Console.WriteLine(DateTime.MinValue);
Console.WriteLine(DateTime.MaxValue);

DateTime date1 = new DateTime(2023, 11, 30);
Console.WriteLine(date1);

DateTime date2 = new DateTime(2023,11,30,13,10,00);
Console.WriteLine(date2);

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.UtcNow);
Console.WriteLine(DateTime.Today);

Console.WriteLine(date2.DayOfWeek);
Console.WriteLine(date2.DayOfYear);
Console.WriteLine(date2.Day);

DateTime date3 = DateTime.Now;
Console.WriteLine(date3.Add(new TimeSpan(12,16,45,0)));

Console.WriteLine(date3.Subtract(date2));
Console.WriteLine(date3.AddDays(500));
Console.WriteLine(date3.AddHours(720));
Console.WriteLine(date3.AddMinutes(3400));
Console.WriteLine(date3.AddYears(-4));

Console.WriteLine(date3.ToLocalTime());
Console.WriteLine(date3.ToUniversalTime());
Console.WriteLine(date3.ToLongDateString());
Console.WriteLine(date3.ToShortDateString());
Console.WriteLine(date3.ToLongTimeString());
Console.WriteLine(date3.ToShortTimeString());

//Форматы даты
Console.WriteLine($"D:{date3.ToString("D")}");
Console.WriteLine($"d:{date3.ToString("d")}");
Console.WriteLine($"F:{date3.ToString("F")}");
Console.WriteLine($"f:{date3.ToString("f")}");
Console.WriteLine($"G:{date3.ToString("G")}");
Console.WriteLine($"g:{date3.ToString("g")}");
Console.WriteLine($"M:{date3:M}");
Console.WriteLine($"O:{date3:O}");
Console.WriteLine($"o:{date3:o}");
Console.WriteLine($"R:{date3:R}");
Console.WriteLine($"s:{date3:s}");
Console.WriteLine($"T:{date3:T}");
Console.WriteLine($"t:{date3:t}");
Console.WriteLine($"U:{date3:U}");
Console.WriteLine($"u:{date3:u}");
Console.WriteLine($"Y:{date3:Y}");

//
Console.WriteLine(DateTime.Now.ToString("g K dd:MM:yyyy hh:mm:ss"));
Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss"));

//DateOnly
DateOnly someDate = new DateOnly();
Console.WriteLine(someDate);
DateOnly dateNow=new DateOnly(2023,11,30);
Console.WriteLine(dateNow);
DateOnly julianDate=new DateOnly(2023,11,30,new JulianCalendar());
Console.WriteLine(julianDate);

Console.WriteLine(dateNow.Day);
Console.WriteLine(dateNow.DayNumber);
Console.WriteLine(dateNow.DayOfWeek);
Console.WriteLine(dateNow.DayOfYear);
Console.WriteLine(dateNow.Month);
Console.WriteLine(dateNow.Year);

Console.WriteLine(dateNow.AddDays(5));
Console.WriteLine(dateNow.AddMonths(2));
Console.WriteLine(dateNow.AddYears(2));
Console.WriteLine(dateNow.ToLongDateString());
Console.WriteLine(dateNow.ToShortDateString());

DateOnly d1 = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(d1);
DateOnly d2 = DateOnly.FromDayNumber(500);
Console.WriteLine(d2);
DateOnly d3 = DateOnly.Parse("2023-11-30");
Console.WriteLine(d3);

//TimeOnly
TimeOnly time = new TimeOnly();
Console.WriteLine(time);
TimeOnly time1=new TimeOnly(13,30,45);
Console.WriteLine(time1);
TimeOnly timeNow=TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(timeNow.Hour);
Console.WriteLine(timeNow.Minute);
Console.WriteLine(timeNow.Second);
Console.WriteLine(timeNow.Millisecond);
Console.WriteLine(timeNow.Ticks);
Console.WriteLine(TimeOnly.MaxValue);
Console.WriteLine(TimeOnly.MinValue);
Console.WriteLine(timeNow.AddHours(5));
Console.WriteLine(timeNow.AddMinutes(5));










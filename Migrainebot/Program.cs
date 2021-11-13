// See https://aka.ms/new-console-template for more information
using System;
using Telegram.Bot;


var token = "1447509072:AAHFaCW18mNcg1Y2PDPMwJrmasWok0JCAUw";


var botClient = new TelegramBotClient(token);
var me = await botClient.GetMeAsync();
Console.WriteLine(
  $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
);

Console.WriteLine("Hello, World! "+token);

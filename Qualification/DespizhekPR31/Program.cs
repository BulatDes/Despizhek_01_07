// See https://aka.ms/new-console-template for more information

using DespizhekPR31.Models;

//Объявление экземляра класса
Cabel cabel = new Cabel("Type1", 7, 21);
//Метод PrintInfo() Вывод информации из класса
cabel.PrintInfo();

PresenceOfBraid presenceOfBraid = new PresenceOfBraid("Type2",2 ,31 ,true);
presenceOfBraid.PrintInfo();

PresenceOfBraid presenceOfBraid2 = new PresenceOfBraid("Type3", 3, 54, false);
presenceOfBraid2.PrintInfo();

// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities;

Console.WriteLine("lÜTFEN BEKLEYİN");
Person person = new Person ();

person.FirstName = "İbrahim";
person.LastName = ",,,,,,,,"; ;
person.NatioanalIdentity = 111111111111;
person.DateOfBirthYear = 2222;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);

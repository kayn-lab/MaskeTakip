// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities;

Console.WriteLine("lÜTFEN BEKLEYİN");
Person person = new Person ();

person.FirstName = "İbrahim";
person.LastName = "Delibaş"; ;
person.NatioanalIdentity = 13484325156;
person.DateOfBirthYear = 2006;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);
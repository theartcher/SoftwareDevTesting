
// Print forname, surname together
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

void FullName(String forename, String surname) {
    Console.WriteLine(forename + " " + surname);
}

//Print int of forname x lastname
void Times(String forename, String surname) {
    int nameLength = forename.Length * surname.Length;
    Console.WriteLine(nameLength);
}

//If character is part of word, return true. Else return false, character als char gedefined voor overzichtelijkheid, zekerheid en storage
void IsIn(String word, char character) { 
    if (word.Contains(character)) {
        Console.WriteLine(true);
    }
    else {
        Console.WriteLine(false);
    }
}

//Check for each char in forname if it is within surname, if so return which characters as strings
void InCommon(String forename, String surname) {

    foreach (char CharacterInName in forename) {

        if (surname.Contains(CharacterInName.ToString())) { 
            Console.WriteLine(CharacterInName);
        }
    }
    
}

//Compare how much longer surname is, if it's longer it'll return the value of how much longer. Otherwise it returns 0.
void HowMuchLonger(String forename, String surname)
{
    int nameDifference = surname.Length - forename.Length;

    if (nameDifference <= 0)
    {
        Console.WriteLine("0");
    }
    else
    {
        Console.WriteLine(nameDifference);
    };

}
//Pakt de voornam uit een volledige naam
void VoornaamVan(String fullname)
{
  string[] nameArray = fullname.Split(' ');
    Console.WriteLine(nameArray[0]);
}

//Pakt de achternaam uit een volledige naam
void AchternaamVan(String fullname)
{
    string[] nameArray = fullname.Split(' ');
    Console.WriteLine(nameArray[1]);
}

//split de volledige naam in voor en achternaam, maakt er char arrays van, reversed deze en plakt ze weer samen als strings.
void NamenAchterstevoren(string fullname)
{
    string[] nameArray = fullname.Split(' ');

    string firstname = nameArray[0];
    string lastname = nameArray[1];

    char[] charFirstname = firstname.ToCharArray();
    char[] charLastName = lastname.ToCharArray();


    //string firstNameReversed = new string(charFirstname);
    //string lastNameReversed = new string(charLastName);

   // Console.WriteLine(ReverseArray(charFirstname) + string.Empty + ReverseArray(charLastName));
    ReverseArray(charFirstname);
    ReverseArray(charLastName);
}


NamenAchterstevoren("Joris Brugman");

static void ReverseArray(char[] characterArray)
{
    List<char> characterList = new List<char>();

    for (int i = characterArray.Length - 1; i <= 0; i--)
    {
        characterList.Add(characterArray[i]);
    }
    string characterString = string.Join("", characterList);
    Console.WriteLine(characterString);
}

/*
static string ReverseArray(char[] characterArray)
{
    List<char> characterList = characterArray.ToList();
    //Reverse method without using .Reverse

    for (int i = 0; i < characterList.Count - 1; i++)
    {
        char lastIndexedChar = characterList.Last();
        int lastIndexList = characterList.Count() - 1;
        characterList.RemoveAt(lastIndexList);
        characterList.Insert(0, lastIndexedChar);
    }
    string stringList = string.Join("", characterList);
    return stringList;
}
*/

void UmEnUmVoorAchter(string fullName)
{
    string[] splittedNameArray = fullName.Split(' ');
    string firstName = splittedNameArray[0];
    string lastName = splittedNameArray[1];

    char[] charArrayFirstName = firstName.ToCharArray();
    char[] charArrayLastName = lastName.ToCharArray();

    for (int i = 0; i >= 0; i++) {

        if (i < charArrayFirstName.Length)
        {
            Console.Write(charArrayFirstName[i] + string.Empty);
        }

        if (i < charArrayLastName.Length) {
            Console.Write(charArrayLastName[i] + string.Empty);
        }
    }
}


//Ga studeren -> oplossing niet zo zeer belangrijk